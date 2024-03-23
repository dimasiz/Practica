namespace TrainsLibrary
{
    public class Train
    {
        public string TrainNumber { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }

        public Train(string trainNumber, string destination, string departureTime)
        {
            TrainNumber = trainNumber;
            Destination = destination;
            DepartureTime = departureTime;
        }

        public  string StringTrain()
        {
            return $"Train Number: {TrainNumber}, Destination: {Destination}, Departure Time: {DepartureTime}";
        }
    }


    public class TrainSchedule
    {
        private List<Train> trains;

        public TrainSchedule()
        {
            trains = new List<Train>();
        }

        public void AddTrain(Train train)
        {
            trains.Add(train);
        }

        public void RemoveTrain(Train train)
        {
            trains.Remove(train);
        }

        public List<Train> GetTrainsByDestination(string destination)
        {
            List<Train> matchingTrains = new List<Train>();
            for (int i = 0; i < trains.Count; i++)
            {
                if (trains[i].Destination == destination)
                {
                    matchingTrains.Add(trains[i]);
                }
            }
            return matchingTrains;
        }

        public List<Train> GetTrainsByDepartureTime(string departureTime)
        {
            List<Train> matchingTrains = new List<Train>();
            for(int i=0; i < trains.Count; i++)
            {
                if (trains[i].DepartureTime == departureTime)
                {
                    matchingTrains.Add(trains[i]);
                }
            }
            return matchingTrains;
        }

       
    }
}
