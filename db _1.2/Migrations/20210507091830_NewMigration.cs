using Microsoft.EntityFrameworkCore.Migrations;

namespace db__1._2.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Client(FirstName, LastName, DateOfBirth, Company) VALUES('Arkadiy', 'Galkin','1999-11-11', 'Galy')
                                   INSERT INTO Client(FirstName, LastName, DateOfBirth, Company) VALUES('Axe', 'Topor','1949-01-21', 'Dire')
                                   INSERT INTO Client(FirstName, LastName, DateOfBirth, Company) VALUES('Mirana', 'Selemin','1990-10-31', 'Radient')
                                   INSERT INTO Client(FirstName, LastName, DateOfBirth, Company) VALUES('Invoker', 'Strange','0001-01-01', 'Tower')
                                   INSERT INTO Client(FirstName, LastName, DateOfBirth, Company) VALUES('Dmitrii', 'Vorona','1999-10-29', 'Bad')");

            migrationBuilder.Sql(@"INSERT INTO Project(Name, Budget, StartedDate, ClientId) VALUES('Push', 1000, '2001-12-31', (SELECT ClientId FROM Client WHERE FirstName = 'Arkadiy'))
                                   INSERT INTO Project(Name, Budget, StartedDate, ClientId) VALUES('Punch', 1001, '2008-02-01', (SELECT ClientId FROM Client WHERE FirstName = 'Axe'))
                                   INSERT INTO Project(Name, Budget, StartedDate, ClientId) VALUES('Build', 1002, '2009-01-11', (SELECT ClientId FROM Client WHERE FirstName = 'Mirana'))
                                   INSERT INTO Project(Name, Budget, StartedDate, ClientId) VALUES('Heal', 1003, '2007-08-05', (SELECT ClientId FROM Client WHERE FirstName = 'Invoker'))
                                   INSERT INTO Project(Name, Budget, StartedDate, ClientId) VALUES('IAmHere', 100, '2000-01-03', (SELECT ClientId FROM Client WHERE FirstName = 'Dmitrii'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Client");
            migrationBuilder.Sql(@"DELETE FROM Project");
        }
    }
}
