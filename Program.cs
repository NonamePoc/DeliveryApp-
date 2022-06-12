using DeliveryApp.EF;
using DeliveryApp.Entities;
using DeliveryApp.Repositories;


namespace DeliveryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var cont = new DeliveryContext();
            // var orderRepository = new OrderRepository(cont);
            // var order = new Order
            // {
            //     Comment = "Qwe",
            //     Date = DateTime.Now,
            //     User = new User("Anton", "123", "anton@gmail.com"),
            //     Phones = new List<Phone>
            //     {
            //         new Phone()
            //         {
            //             Model = "Phone",
            //             NumbersSim = 113213,
            //             Ram = 12
            //         },
            //         new Phone()
            //         {
            //             
            //         }
            //     }
            // };
            var userInformationRepository = new UserInformationRepository(cont);
            var userinfo = new UserInformation
            {
                Address = "dasda",
                Name = "Anton",
                LastName = "Krut",
                User = new User("Anton1", "123", "anton@gmail.com")
            };
            // orderRepository.Add(order);
            // var s = orderRepository.GetAll();
            userInformationRepository.Add(userinfo);
            var s1 = userInformationRepository.GetAll();

        }
    }
}