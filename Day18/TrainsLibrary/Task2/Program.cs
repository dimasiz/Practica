using TrainsLibrary;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("utf-16");

            TrainSchedule schedule = new TrainSchedule();

            Train train1 = new Train("123", "Москва", "10:00");
            Train train2 = new Train("456", "Санкт-Петербург", "12:30");
            Train train3 = new Train("789", "Новосибирск", "15:45");
            Train train4 = new Train("111", "Гродно", "12:10");
            Train train5 = new Train("093", "Поречье", "11:35");
            Train train6 = new Train("113", "Москва", "12:00");


            schedule.AddTrain(train1);
            schedule.AddTrain(train2);
            schedule.AddTrain(train3);
            schedule.AddTrain(train4);
            schedule.AddTrain(train5);
            schedule.AddTrain(train6);

            
            
            
            Console.WriteLine("Введите пункт назначения для поиска поездов:");
            string destination = Console.ReadLine();

            List<Train> trainsByDestination = schedule.GetTrainsByDestination(destination);
            if (trainsByDestination.Count > 0)
            {
                Console.WriteLine($"Найдено поездов с пунктом назначения '{destination}':");
                foreach (Train train in trainsByDestination)
                {
                    Console.WriteLine($"Номер: {train.TrainNumber}  Пункт отправление: {train.Destination}  Время отправление: {train.DepartureTime}");
                }
            }
            else
            {
                Console.WriteLine($"Поездов с пунктом назначения '{destination}' не найдено.");
            }

            
            Console.WriteLine("Введите время отправления для поиска поездов:");
            string departureTime = Console.ReadLine();

            List<Train> trainsByDepartureTime = schedule.GetTrainsByDepartureTime(departureTime);
            if (trainsByDepartureTime.Count > 0)
            {
                Console.WriteLine($"Найдено поездов с временем отправления '{departureTime}':");
                foreach (Train train in trainsByDepartureTime)
                {
                    Console.WriteLine($"Номер: {train.TrainNumber}  Пункт отправление: {train.Destination}  Время отправление: {train.DepartureTime}");
                }
            }
            else
            {
                Console.WriteLine($"Поездов с временем отправления '{departureTime}' не найдено.");
            }

            Console.ReadLine();
        }
    }
}
