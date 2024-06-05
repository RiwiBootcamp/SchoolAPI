cd $rootProjectDir

###--------- PROJECT SKELETON ---------###
mkdir -p "Controllers/"
mkdir -p "Services/"
mkdir -p "Services/HttpMethods"
mkdir -p "Data/SQL"
mkdir Models

##---- Creation of model
mkdir -p "Controllers/${globalModelNaming}"
mkdir -p "Services/${globalModelNaming}Repository/Methods"

##--- SQL
touch Data/SQL/Data.sql
touch Data/SQL/Tables.sql