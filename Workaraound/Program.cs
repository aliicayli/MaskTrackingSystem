using Business.Concrete;
using Entities.Concrete;


Person p = new Person() { FirstName = "Ali", LastName = "Çaylı", DateOfBirthYear = 2000, Identity = 1 };
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(p);