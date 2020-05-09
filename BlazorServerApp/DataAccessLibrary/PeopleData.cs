using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _sqlDataAccess;

        public PeopleData(ISqlDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }

        public Task<List<Person>> GetPeople()
        {
            string sql = "select * from dbo.People";

            return _sqlDataAccess.LoadData<Person, dynamic>(sql, new { });
        }

        public Task InsertPerson(Person person)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
                         values (@FirstName, @LastName, @EmailAddress);";

            return _sqlDataAccess.SaveData<Person>(sql, person);
        }
    }
}
