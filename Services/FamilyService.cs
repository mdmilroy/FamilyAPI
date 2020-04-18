using Data;
using Models;
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
                                Birthdate = e.Birthdate
                            });

                return query.ToArray();
            }
        }
    }
}
