
namespace ConsoleQuiz
{
    public static class Questions
    {
        public static List<Question> GetQuestionsList()
        {
            Random random = new Random();

            string promptStart = "What is the capital of";

            return new List<Question>
{
    new Question { Prompt = $"{promptStart} Argentina?", Options = ShuffleOptions(new[] { "Buenos Aires", "Santiago", "Montevideo", "Asunción" }, random), CorrectOption = "Buenos Aires" },
    new Question { Prompt = $"{promptStart} Australia?", Options = ShuffleOptions(new[] { "Sydney", "Canberra", "Melbourne", "Auckland" }, random), CorrectOption = "Canberra" },
    new Question { Prompt = $"{promptStart} Belgium?", Options = ShuffleOptions(new[] { "Brussels", "Antwerp", "Ghent", "Bruges" }, random), CorrectOption = "Brussels" },
    new Question { Prompt = $"{promptStart} Brasil?", Options = ShuffleOptions(new[] { "Buenos Aires", "Lima", "Brasília", "Caracas" }, random), CorrectOption = "Brasília" },
    new Question { Prompt = $"{promptStart} Canada?", Options = ShuffleOptions(new[] { "Ottawa", "Toronto", "Vancouver", "Montreal" }, random), CorrectOption = "Ottawa" },
    new Question { Prompt = $"{promptStart} Chile?", Options = ShuffleOptions(new[] { "Santiago", "Valparaiso", "Concepcion", "Puerto Montt" }, random), CorrectOption = "Puerto Montt" },
    new Question { Prompt = $"{promptStart} China?", Options = ShuffleOptions(new[] { "Shanghai", "Beijing", "Hong Kong", "Taipei" }, random), CorrectOption = "Beijing" },
    new Question { Prompt = $"{promptStart} Colombia?", Options = ShuffleOptions(new[] { "Barranquilla", "Medellín", "Cali", "Bogotá" }, random), CorrectOption = "Barranquilla" },
    new Question { Prompt = $"{promptStart} Denmark?", Options = ShuffleOptions(new[] { "Copenhagen", "Aarhus", "Odense", "Aalborg" }, random), CorrectOption = "Copenhagen" },
    new Question { Prompt = $"{promptStart} Egypt?", Options = ShuffleOptions(new[] { "Cairo", "Alexandria", "Istanbul", "Casablanca" }, random), CorrectOption = "Cairo" },
    new Question { Prompt = $"{promptStart} Finland?", Options = ShuffleOptions(new[] { "Helsinki", "Espoo", "Tampere", "Turku" }, random), CorrectOption = "Helsinki" },
    new Question { Prompt = $"{promptStart} France?", Options = ShuffleOptions(new[] { "Berlin", "Paris", "Madrid", "Rome" }, random), CorrectOption = "Paris" },
    new Question { Prompt = $"{promptStart} Germany?", Options = ShuffleOptions(new[] { "Berlin", "Hamburg", "Munich", "Frankfurt" }, random), CorrectOption = "Berlin" },
    new Question { Prompt = $"{promptStart} Greece?", Options = ShuffleOptions(new[] { "Athens", "Thessaloniki", "Crete", "Izmir" }, random), CorrectOption = "Athens" },
    new Question { Prompt = $"{promptStart} Hungary?", Options = ShuffleOptions(new[] { "Budapest", "Debrecen", "Szeged", "Pecs" }, random), CorrectOption = "Budapest" },
    new Question { Prompt = $"{promptStart} India?", Options = ShuffleOptions(new[] { "New Delhi", "Mumbai", "Bangalore", "Islamabad" }, random), CorrectOption = "New Delhi" },
    new Question { Prompt = $"{promptStart} Indonesia?", Options = ShuffleOptions(new[] { "Jakarta", "Bali", "Surabaya", "Manila" }, random), CorrectOption = "Jakarta" },
    new Question { Prompt = $"{promptStart} Iran?", Options = ShuffleOptions(new[] { "Tehran", "Isfahan", "Shiraz", "Baghdad" }, random), CorrectOption = "Tehran" },
    new Question { Prompt = $"{promptStart} Ireland?", Options = ShuffleOptions(new[] { "Dublin", "Cork", "Galway", "Belfast" }, random), CorrectOption = "Galway" },
    new Question { Prompt = $"{promptStart} Italy?", Options = ShuffleOptions(new[] { "Rome", "Milan", "Venice", "Florence" }, random), CorrectOption = "Rome" },
    new Question { Prompt = $"{promptStart} Japan?", Options = ShuffleOptions(new[] { "Beijing", "Seoul", "Tokyo", "Bangkok" }, random), CorrectOption = "Tokyo" },
    new Question { Prompt = $"{promptStart} Kenya?", Options = ShuffleOptions(new[] { "Nairobi", "Mombasa", "Kampala", "Dar es Salaam" }, random), CorrectOption = "Nairobi" },
    new Question { Prompt = $"{promptStart} Malaysia?", Options = ShuffleOptions(new[] { "Kuala Lumpur", "Penang", "Langkawi", "Kota Kinabalu" }, random), CorrectOption = "Kota Kinabalu" },
    new Question { Prompt = $"{promptStart} Mexico?", Options = ShuffleOptions(new[] { "Mexico City", "Guadalajara", "Monterrey", "Bogotá" }, random), CorrectOption = "Mexico City" },
    new Question { Prompt = $"{promptStart} Morocco?", Options = ShuffleOptions(new[] { "Casablanca", "Marrakech", "Rabat", "Fez" }, random), CorrectOption = "Fez" },
    new Question { Prompt = $"{promptStart} Netherlands?", Options = ShuffleOptions(new[] { "Amsterdam", "Rotterdam", "The Hague", "Brussels" }, random), CorrectOption = "Amsterdam" },
    new Question { Prompt = $"{promptStart} New Zealand?", Options = ShuffleOptions(new[] { "Wellington", "Auckland", "Christchurch", "Hamilton" }, random), CorrectOption = "Wellington" },
    new Question { Prompt = $"{promptStart} Nigeria?", Options = ShuffleOptions(new[] { "Lagos", "Abuja", "Kano", "Accra" }, random), CorrectOption = "Abuja" },
    new Question { Prompt = $"{promptStart} Norway?", Options = ShuffleOptions(new[] { "Oslo", "Bergen", "Trondheim", "Stavanger" }, random), CorrectOption = "Trondheim" },
    new Question { Prompt = $"{promptStart} Pakistan?", Options = ShuffleOptions(new[] { "Islamabad", "Karachi", "Lahore", "Delhi" }, random), CorrectOption = "Islamabad" },
    new Question { Prompt = $"{promptStart} Peru?", Options = ShuffleOptions(new[] { "Lima", "Cusco", "Arequipa", "Trujillo" }, random), CorrectOption = "Cusco" },
    new Question { Prompt = $"{promptStart} Philippines?", Options = ShuffleOptions(new[] { "Manila", "Cebu", "Davao", "Quezon City" }, random), CorrectOption = "Manila" },
    new Question { Prompt = $"{promptStart} Portugal?", Options = ShuffleOptions(new[] { "Lisbon", "Porto", "Braga", "Faro" }, random), CorrectOption = "Lisbon" },
    new Question { Prompt = $"{promptStart} Russia?", Options = ShuffleOptions(new[] { "Moscow", "St. Petersburg", "Kiev", "Warsaw" }, random), CorrectOption = "Moscow" },
    new Question { Prompt = $"{promptStart} Saudi Arabia?", Options = ShuffleOptions(new[] { "Riyadh", "Jeddah", "Mecca", "Doha" }, random), CorrectOption = "Riyadh" },
    new Question { Prompt = $"{promptStart} Singapore?", Options = ShuffleOptions(new[] { "Singapore City", "Jurong", "Chinatown", "Marina Bay" }, random), CorrectOption = "Singapore City" },
    new Question { Prompt = $"{promptStart} South Korea?", Options = ShuffleOptions(new[] { "Seoul", "Busan", "Incheon", "Tokyo" }, random), CorrectOption = "Seoul" },
    new Question { Prompt = $"{promptStart} Spain?", Options = ShuffleOptions(new[] { "Madrid", "Barcelona", "Seville", "Valencia" }, random), CorrectOption = "Madrid" },
    new Question { Prompt = $"{promptStart} Switzerland?", Options = ShuffleOptions(new[] { "Zurich", "Geneva", "Bern", "Basel" }, random), CorrectOption = "Zurich" },
    new Question { Prompt = $"{promptStart} Thailand?", Options = ShuffleOptions(new[] { "Bangkok", "Phuket", "Chiang Mai", "Hanoi" }, random), CorrectOption = "Bangkok" },
    new Question { Prompt = $"{promptStart} Turkey?", Options = ShuffleOptions(new[] { "Istanbul", "Ankara", "Izmir", "Athens" }, random), CorrectOption = "Ankara" },
    new Question { Prompt = $"{promptStart} Ukraine?", Options = ShuffleOptions(new[] { "Kyiv", "Kharkiv", "Lviv", "Odessa" }, random), CorrectOption = "Kyiv" },
    new Question { Prompt = $"{promptStart} United Kingdom?", Options = ShuffleOptions(new[] { "London", "Edinburgh", "Manchester", "Dublin" }, random), CorrectOption = "London" },
    new Question { Prompt = $"{promptStart} United States?", Options = ShuffleOptions(new[] { "Washington, D.C.", "New York City", "Los Angeles", "Chicago" }, random), CorrectOption = "Washington, D.C." },
    new Question { Prompt = $"{promptStart} Venezuela?", Options = ShuffleOptions(new[] { "Caracas", "Maracaibo", "Valencia", "Barquisimeto" }, random), CorrectOption = "Caracas" },
    new Question { Prompt = $"{promptStart} Vietnam?", Options = ShuffleOptions(new[] { "Hanoi", "Ho Chi Minh City", "Da Nang", "Phnom Penh" }, random), CorrectOption = "Hanoi" },
    new Question { Prompt = $"{promptStart} Zimbabwe?", Options = ShuffleOptions(new[] { "Harare", "Bulawayo", "Mutare", "Gweru" }, random), CorrectOption = "Harare" },
};
        }

            public static string[] ShuffleOptions(string[] options, Random random)
        {
            string[] shuffledOptions = options.ToArray();

            for (int i = shuffledOptions.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                string temp = shuffledOptions[i];
                shuffledOptions[i] = shuffledOptions[j];
                shuffledOptions[j] = temp;
            }

            return shuffledOptions;
        }
    }
}
