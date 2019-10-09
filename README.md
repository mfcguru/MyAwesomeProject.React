# MyAwesomeProject

![Alt Text](https://media.licdn.com/dms/image/C5112AQFc22WDnkRroQ/article-inline_image-shrink_1000_1488/0?e=1576108800&v=beta&t=3-k-P4l2R4Vd_eTtik8Jhby_dDFP54b1Jc964YDjVHc)

### Open the solution in Visual Studio and do a rebuild-all. Once build is complete go inside the MyAwesomeProject.Api folder and execute the codefirst-migration.bat to build the database. The migration script assumes that you have SQLExpress installed locally. Otherwise, you will need to correct your connection string inside the app appSettings.json.

![Alt Text](https://media.licdn.com/dms/image/C5112AQEl_WoYZI5lVw/article-inline_image-shrink_1000_1488/0?e=1576108800&v=beta&t=aOTqkWkar71J8r2RU7NR8gmH5f2RKiiiQQ4P-QF81Cs)
![Alt Text](https://media.licdn.com/dms/image/C5112AQEhtJjBjDTjuw/article-inline_image-shrink_1500_2232/0?e=1576108800&v=beta&t=hg2g07-h3IA5o6FRAnBwNoV2lqgS4v2rJjjQV-hc2VY)

### When code first code migration is complete we should be able to run our application. Hit F5 and wait for the swagger page to appear. Do take note of the URL, particularly the port number, as we will have to tell the React front-end that this is the server address that we will be connecting to.

![Alt Text](https://media.licdn.com/dms/image/C5112AQFYIagYM3v9yQ/article-inline_image-shrink_1000_1488/0?e=1576108800&v=beta&t=2u2LtEzGqkZioWSnWsTNwev6Tk2Qbq7jHxB2oTCMexc)

### With the web API already running we are now ready to generate the React front end code. We basically do the same. We navigate to the React Jabit! folder and execute code generation from there. But before doing so make sure that you also replaced the default Northwind schema with the schema that we used when we generated the .NET Core API.

### Afterwards, the React generated code can be found inside the output folder inside the React Jabit! directory.


