namespace Task
{
    //Интерфейс ввода данных
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    //Класс арифметической прогрессии
    class ArithProgression : ISeries
    {
        int beginValue;
        int nextValue;
        int step;

        //метод получения очередного значения
        public int getNext()
        {
            nextValue += step;
            return nextValue;
        }

        //метод сброса прогрессии к начальному значению
        public void reset()
        {
            nextValue = beginValue;
        }

        //метод установки начального значения
        public void setStart(int x)
        {
            beginValue = x;
            nextValue = beginValue;
        }
        //метод установки начального шага
        public void setStep(int step)
        {
            this.step = step;
        }
    }
    //Класс геометрической прогрессии
    class GeomProgression : ISeries
    {
        int beginValue;
        int nextValue;
        int step;

        //метод получения очередного значения
        public int getNext()
        {
            nextValue *= step;
            return nextValue;
        }

        //метод сброса прогрессии к начальному значению
        public void reset()
        {
            nextValue = beginValue;
        }

        //метод установки начального значения
        public void setStart(int x)
        {
            beginValue = x;
            nextValue = beginValue;
        }
        //метод установки начального шага
        public void setStep(int step)
        {
            this.step = step;
        }
    }
}