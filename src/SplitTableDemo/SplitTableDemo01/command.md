docker build -f DockerfileSimple -t atest:0.0.1 .


docker run -itd --rm --name busybox01 busybox sh


docker run -itd --name atest01 -p 10010:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest02 -p 10011:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest03 -p 10012:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest04 -p 10013:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest05 -p 10014:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest06 -p 10015:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest07 -p 10016:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest08 -p 10017:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest09 -p 10018:8080 atest:0.0.1 /bin/bash
docker run -itd --name atest10 -p 10019:8080 atest:0.0.1 /bin/bash


docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest01
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest02
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest03
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest04
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest05
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest06
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest07
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest08
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest09
docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' atest10




http://42.192.219.38:8279/api/member/GetMemberInfo?memberId=1

http://42.192.219.38:10010/api/member/GetMemberInfo?memberId=1




curl http://172.17.0.15:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.16:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.17:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.18:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.19:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.20:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.21:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.22:8080/api/member/GetMemberInfo?memberId=1741363403429122091
curl http://172.17.0.23:8080/api/member/GetMemberInfo?memberId=1741363403429122091



docker stats mysql02 atest01 atest02 atest03 atest04  atest06 atest07 atest08 atest09 atest10

计算机\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters


#启动脚本是在
# /usr/local/nginx/sbin/nginx
#启动,
/usr/local/nginx/sbin/nginx -c /usr/local/nginx/conf/nginx.conf
#停止
/usr/local/nginx/sbin/nginx -s stop
#重载
/usr/local/nginx/sbin/nginx -s reload
#杀掉nginx
/usr/local/nginx/sbin/nginx -s quit


查询nginx是否启动：
ps -ef | grep nginx




    upstream backend {
        server 172.17.0.15:8080;
        server 172.17.0.16:8080;
        server 172.17.0.17:8080;
        server 172.17.0.18:8080;
        server 172.17.0.19:8080;
        server 172.17.0.20:8080;
        server 172.17.0.21:8080;
        server 172.17.0.22:8080;
        server 172.17.0.23:8080;
    }