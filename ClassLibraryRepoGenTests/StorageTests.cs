using System.Collections.Generic;
using ClassLibraryRepoGen;
using ClassLibraryRepoGen.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryRepoGenTests
{
    [TestClass()]
    public class StorageTests
    {
        [TestMethod()]
        public void AllTest()
        {
            Storage<Car> storage=new Storage<Car>();
            storage.Add(new Car(5,"aaqsdsqd",3,Status.Inops),
                new Car(1, "aqsdsqd", 3, Status.Inops),
                new Car(2, "cqsdsqd", 3, Status.Inops),
                new Car(3, "bqsdsqd", 5, Status.Operational),
                new Car(4, "vqsdsqd", 3, Status.Inops)


                );
            Assert.AreEqual(5, storage.Count());
        }


        [TestMethod()]
        public void AgeTest()
        {
            Storage<Car> storage = new Storage<Car>();
            storage.Add(new Car(5, "aaqsdsqd", 3, Status.Inops),
                new Car(1, "aqsdsqd", 3, Status.Inops),
                new Car(2, "cqsdsqd", 3, Status.Inops),
                new Car(3, "bqsdsqd", 5, Status.Operational),
                new Car(4, "vqsdsqd", 4, Status.Inops)


            );
            Assert.AreEqual(3, storage.Age(3).Count);
            Assert.AreEqual(4, storage.Predicate((e) => (e.Status ==Status.Inops)).Count);
        }

        [TestMethod()]
        public void AllAirPlaneTest()
        {
            Storage<AirPlane> storage = new Storage<AirPlane>();
            storage.Add(new AirPlane(5, "aaqsdsqd", 3, 5,8),
                new AirPlane(4, "zaaqsdsqd", 3, 5, 8),
                new AirPlane(2, "caaqsdsqd", 3, 5, 8),
                new AirPlane(1, "kaaqsdsqd", 3, 5, 8),
                new AirPlane(7, "kkkkkaaqsdsqd", 3, 5, 8)


            );
            Assert.AreEqual(5, storage.Count());
        }


        [TestMethod()]
        public void AgeAirplaneTest()
        {
            Storage<AirPlane> storage = new Storage<AirPlane>();
            storage.Add(new AirPlane(5, "aaqsdsqd", 3, 5, 8),
                new AirPlane(4, "zaaqsdsqd", 3, 57, 8),
                new AirPlane(2, "caaqsdsqd", 3, 5, 8),
                new AirPlane(1, "kaaqsdsqd", 3, 59, 8),
                new AirPlane(7, "kkkkkaaqsdsqd", 30, 5, 8)
                
            );
            Assert.AreEqual(1, storage.Age(30).Count);
           
        }

        [TestMethod()]
        public void AgeAirplanePredicateTest()
        {
            Storage<AirPlane> storage = new Storage<AirPlane>();
            storage.Add(new AirPlane(5, "aaqsdsqd", 3, 5, 8),
                new AirPlane(4, "zaaqsdsqd", 34, 57, 8),
                new AirPlane(2, "caaqsdsqd", 3, 5, 8),
                new AirPlane(1, "kaaqsdsqd", 34, 59, 8),
                new AirPlane(7, "kkkkkaaqsdsqd", 3, 5, 8)

            );
            Assert.AreEqual(2, storage.Age(34).Count);
            Assert.AreEqual(2, storage.Predicate((e) => (e.Span > 5)).Count);
            Assert.AreEqual(5, storage.Predicate((e) => (e.CountEngines >1)).Count);
        }
    }
}