# Docker / MySQL Container

## Run a mysql server container

`docker run --detach --name=test-mysql --env="MYSQL_ROOT_PASSWORD=mypassword" mysql`

## View container enviroment variables

`docker inspect -f "{{ .Config.Env }}" test-mysql`

## Bash Terminal

`docker run -it mysql /bin/bash`

## MySQL Client

`docker run -it --link test-mysql:mysql --rm mysql sh -c 'exec mysql -h"$MYSQL_PORT_3306_TCP_ADDR" -P"$MYSQL_PORT_3306_TCP_PORT" -uroot -p"$MYSQL_ENV_MYSQL_ROOT_PASSWORD"'`
