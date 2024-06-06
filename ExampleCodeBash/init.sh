## Get to root dir
declare rootBashDir=`pwd`

cd ../
declare rootDir=`pwd`

## Go back to root dir
cd $rootBashDir

##----- GLOBAL VARIBLES -----##
declare projectName="SchoolApi"
declare modelName="Cou"
declare globalModelNaming=${modelName}s

declare rootProjectDir="${rootDir}/${projectName}"

##----- HELPER FUNCTIONS -----##
# goToProjectDir()
# {
#   ## Equal to: BondHealt(root dir)/BondHeath(main dir)
#   cd ${rootProjectDir}/${projectName}
#   cd ./$1
# }

export rootProjectDir
export globalModelNaming
export modelName

##----- START -----##
##---- Project Skeleton
./projectSkeleton.sh

##--- BaseContext
./Data/BaseContext.sh

##--- Http methods
./Services/HttpMethods/IHttpGet.sh
./Services/HttpMethods/IHttpPost.sh
./Services/HttpMethods/IHttpPut.sh
./Services/HttpMethods/IHttpDelete.sh

##--- Controllers
./Controllers/GetController.sh
./Controllers/CreateController.sh
./Controllers/UpdateController.sh
./Controllers/DeleteController.sh

##--- Model
./Models/Model.sh

##--- REPOSITORY ---##
#-- Methods
./Services/Repository/Methods/Get.sh
./Services/Repository/Methods/Create.sh
./Services/Repository/Methods/Update.sh
./Services/Repository/Methods/Delete.sh

#-- Repository
./Services/Repository/Repository.sh
./Services/Repository/IRepository.sh

#-- Remove chmod for prevention
chmod -x init.sh