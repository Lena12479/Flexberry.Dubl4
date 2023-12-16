docker build --no-cache -f SQL\Dockerfile.PostgreSql -t dubl4/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t dubl4/app ../..
