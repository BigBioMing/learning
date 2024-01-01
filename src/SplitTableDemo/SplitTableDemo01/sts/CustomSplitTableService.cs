using SqlSugar;
using System.Reflection;

namespace SplitTableDemo01.sts
{
    public class CustomSplitTableService : ISplitTableService
    {
        /// <summary>
        /// 每张表最大数据量
        /// </summary>
        public int PerTableMaxDataCount = 30;
        /// <summary>
        /// 返回数据库中所有分表
        /// </summary>
        /// <param name="db"></param>
        /// <param name="EntityInfo"></param>
        /// <param name="tableInfos"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<SplitTableInfo> GetAllTables(ISqlSugarClient db, EntityInfo EntityInfo, List<DbTableInfo> tableInfos)
        {
            string splitTableNamePrefix = $"{EntityInfo.DbTableName}_";
            List<SplitTableInfo> result = new List<SplitTableInfo>();
            foreach (var item in tableInfos)
            {
                if (item.Name.Contains(splitTableNamePrefix)) //区分标识如果不用正则符复杂一些，防止找错表
                {
                    SplitTableInfo data = new SplitTableInfo()
                    {
                        TableName = item.Name //要用item.name不要写错了
                    };
                    result.Add(data);
                }
            }
            return result.OrderBy(it => it.TableName).ToList();//打断点看一下有没有查出所有分表
        }

        /// <summary>
        /// 获取分表字段的值
        /// </summary>
        /// <param name="db"></param>
        /// <param name="entityInfo"></param>
        /// <param name="splitType"></param>
        /// <param name="entityValue"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetFieldValue(ISqlSugarClient db, EntityInfo entityInfo, SplitType splitType, object entityValue)
        {
            var splitColumn = entityInfo.Columns.FirstOrDefault(it => it.PropertyInfo.GetCustomAttribute<SplitFieldAttribute>() != null);
            var value = splitColumn.PropertyInfo.GetValue(entityValue, null);
            return value;
        }

        /// <summary>
        /// 默认表名
        /// </summary>
        /// <param name="db"></param>
        /// <param name="EntityInfo"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTableName(ISqlSugarClient db, EntityInfo EntityInfo)
        {
            return EntityInfo.DbTableName + "_0";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="EntityInfo"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTableName(ISqlSugarClient db, EntityInfo EntityInfo, SplitType type)
        {
            return EntityInfo.DbTableName + "_0";//目前模式少不需要分类(自带的有 日、周、月、季、年等进行区分)
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="entityInfo"></param>
        /// <param name="splitType"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTableName(ISqlSugarClient db, EntityInfo entityInfo, SplitType splitType, object fieldValue)
        {
            long fieldValueLong = Convert.ToInt64(fieldValue);
            long index = fieldValueLong % PerTableMaxDataCount + 1;
            return entityInfo.DbTableName + "_" + index;
        }
    }
}
