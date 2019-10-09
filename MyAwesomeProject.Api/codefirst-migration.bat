@echo off
echo Starting code first migrations, please do not close this window...
echo dotnet ef migrations add NewMigration --project ../MyAwesomeProject.Data, started...
dotnet ef migrations add NewMigration --project ../MyAwesomeProject.Data
echo dotnet ef database update, started...
dotnet ef database update
echo performing clean up...
rd /s /q "../MyAwesomeProject.Data/Migrations"
echo It is now safe to close the window
pause