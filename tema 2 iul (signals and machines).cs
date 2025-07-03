namespace tema_2_iul__clase_
{
    internal class Signal
    {
        private string _name;
        private double[] _data,_time;
        public static int count=0;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public double[] Time
        { 
            get { return _time; }
            set { _time = value; }
        }

        public Signal(string name, double[] data, double[] time)
        {
            Name = name;
            Data = data;
            Time = time;
            count++;
        }

        public void CleanNoise()
        {
            for (int i= 0; i < Data.Length;i++)
            {
                if (Data[i] < 0)
                    Data[i] = 0.00;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.Write("Data:");
            for (int i = 0; i < Data.Length; i++)
            {
                Console.Write($"({Time[i]:F2},{Data[i]:F2}) ");
            }
            Console.WriteLine();
        }
        public double[] GetData(double startTime, double endTime)
        {
            double[] doubles = new double[Data.Length];
            int k = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                if (Time[i] >= startTime && Time[i] <= endTime)
                { doubles[k] = Data[i]; k++; }
            }
            return doubles;
        }

        public static Signal Merge(Signal signal1, Signal signal2)
        {
            int i = 0, j = 0, k=0;
            double[] data3 = new double[signal1.Data.Length+signal2.Data.Length],time3=new double[signal1.Time.Length+ signal2.Time.Length];
            while(i<signal1.Data.Length && j<signal2.Data.Length)
            {
                if (signal1.Time[i] < signal2.Time[j])
                {
                    data3[k]=signal1.Data[i];
                    time3[k]=signal1.Time[i];
                    i++;
                }
                else
                {
                    data3[k]=signal2.Data[j];
                    time3[k]=signal2.Time[j];
                    j++;
                }
                k++;
            }
            while(i<signal1.Data.Length)
            {
                data3[k] = signal1.Data[i];
                time3[k] = signal1.Time[i];
                i++;k++;
            }
            while(j<signal2.Data.Length)
            {
                data3[k] = signal2.Data[j];
                time3[k] = signal2.Time[j];
                k++;j++;
            }
            return new Signal("Merged", data3, time3);
        }
        public int getRecordsNumber()
        {
            return count;
        }
    }
    
    internal class Machine
    {
        public int currentSignalIndex=0, MAX_SIGNALS = 10;
        public Signal[] signals;
        public string name;

        public Machine(string _name)
        {
            name = _name;
            signals=new Signal[MAX_SIGNALS];
        }
        public void AddSignal(Signal signal)
        {
            if (currentSignalIndex < MAX_SIGNALS)
            {
                signals[currentSignalIndex] = signal;
                currentSignalIndex++;
            }
            else
            {
                Console.WriteLine("You cannot add any more signals!");
            }
        }
        public void ChangeSignal(int index, Signal signal)
        {
            signals[index] = signal;
        }

        public Signal GetMaxSignal(double time)
        {
            int maxValueIndex=0;
            double maxValue = -99;
            for(int i=0;i<currentSignalIndex;i++)
            {
                double[] aux = signals[i].GetData(time-1,time+1);
                for(int j=0;j<aux.Length;j++)
                {
                    if(aux[j] > maxValue)
                    {
                        maxValue = aux[j];
                        maxValueIndex = i;
                    }
                }
            }
            return signals[maxValueIndex];
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Machine: {name}");
            Console.WriteLine("Signals: ");
            for (int i = 0; i < currentSignalIndex; i++)
            {
                signals[i].PrintInfo();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine("My machine");
            Random random = new Random();
            for (int i=0;i<5;i++)
            {
                double[] data = new double[7];
                double[] time = new double[7];
                for(int j=0;j<7;j++)
                {
                    data[j] = random.NextDouble()*20 -10;
                    time[j]=random.NextDouble()+j;
                }
                Signal signal = new Signal("Signal" + i, data, time);
                machine.AddSignal(signal);
            }
            Console.WriteLine("Raw signals: ");
            machine.PrintInfo();

            Console.WriteLine();

            Signal signal1 = machine.signals[0];
            Signal signal2 = machine.signals[1];
            Signal mergedSignal= Signal.Merge(signal1 , signal2);
            mergedSignal.PrintInfo();

            Console.WriteLine();

            Console.WriteLine("Clean signals: ");
            foreach(Signal signal in machine.signals)
            {
                if (signal != null)
                    signal.CleanNoise();
            }
            machine.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("The signal with the highest value in time [4,6]: ");
            Signal maxSignal = machine.GetMaxSignal(5);
            maxSignal.PrintInfo();
        }
    }
}
