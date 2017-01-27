# Docker / MySQL Container

In this document we assume the container is called test-mysql and the password is mypassword.

### Run a mysql server container

`docker run --detach --name=test-mysql --env="MYSQL_ROOT_PASSWORD=mypassword" mysql`

### MySQL Client

`docker run -it --link test-mysql:mysql --rm mysql sh -c 'exec mysql -h"$MYSQL_PORT_3306_TCP_ADDR" -P"$MYSQL_PORT_3306_TCP_PORT" -uroot -p"$MYSQL_ENV_MYSQL_ROOT_PASSWORD"'`

# General Docker Commands

Here are some basic docker commands

### View Container Logs

`docker logs test-mysql`

### Bash Terminal

`docker run -it mysql /bin/bash`


### View container enviroment variables

`docker inspect -f "{{ .Config.Env }}" test-mysql`

### List containers

`docker ps -a`

### Start/Stop containers

`docker start test-mysql`

`docker stop test-mysql`

### Remove container

`docker rm test-mysql`

### View docker images

`docker images -a

### Remove image

`docker rmi image-name`

