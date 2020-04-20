using Data;
using Models;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FamilyService
    {
        private readonly Guid _userId;

        public FamilyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePerson(AddPerson person)
        {
            var entity =
                new Person()
                {
                    ID = _userId,
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Birthdate = person.Birthdate,
                    PhoneNumber = person.PhoneNumber,
                    Married = person.Married,
                    Occupation = person.Occupation,
                    IsVeteran = person.IsVeteran
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.People.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<FamilyListPeople> GetFamily()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .People
                        .Where(e => e.ID == _userId)
                        .Select(
                            e => new FamilyListPeople
                            {
                                ID = e.ID,
                                FirstName = e.FirstName,
                                LastName = e.LastName,
                                Relatives = e.Relatives
                            });

                return query.ToArray();
            }
        }
    }
}
