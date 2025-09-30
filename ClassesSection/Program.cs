// See https://aka.ms/new-console-template for more information
using ClassesSection;

Text text = new Text();
text.Width = 200;
text.Copy();

var dbMigrator = new DBMigrator(new Logger());
var logger=new Logger();
var installer = new Installer(logger);
dbMigrator.Migrate();
installer.Install();
