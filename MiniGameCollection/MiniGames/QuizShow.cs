namespace MiniGameCollection.MiniGames;

public class QuizShow : IMiniGame
{
    public string Name => "Quiz Show";

    public string Description => "Can you answer all the questions correctly?";

    private readonly List<Question> questions = new()
    {
        new Question("What is the capital of France?", ["Berlin", "Madrid", "Paris", "Rome"], 2),
        new Question("Which planet is known as the Red Planet?", ["Venus", "Mars", "Jupiter", "Saturn"], 1),
        new Question("Who wrote 'Romeo and Juliet'?", ["William Shakespeare", "Charles Dickens", "Jane Austen", "Mark Twain"], 0),
        new Question("What is the largest ocean on Earth?", ["Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean"], 1),
        new Question("What is the chemical symbol for gold?", ["Ag", "Fe", "Pb", "Au"], 3),
        new Question("In which year did the Titanic sink?", ["1905", "1912", "1920", "1898"], 1),
        new Question("What is the hardest natural substance on Earth?", ["Diamond", "Gold", "Iron", "Platinum"], 0),
        new Question("How many continents are there on Earth?", ["5", "6", "8", "7"], 3),
        new Question("Which gas do plants absorb from the atmosphere?", ["Carbon Dioxide", "Oxygen", "Nitrogen", "Hydrogen"], 0),
        new Question("What is the tallest mammal in the world?", ["Elephant", "Blue Whale", "Giraffe", "Horse"], 2),
        new Question("Who painted the Mona Lisa?", ["Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet"], 1),
        new Question("What is the smallest prime number?", ["0", "1", "3", "2"], 3),
        new Question("Which country is home to the kangaroo?", ["Australia", "South Africa", "Austria", "India"], 0),
        new Question("What is the approximate speed of light in a vacuum?", ["150,000 km/s", "300,000 km/s", "1,000 km/s", "3,000,000 km/s"], 1),
        new Question("Which element has the atomic number 1?", ["Hydrogen", "Helium", "Oxygen", "Carbon"], 0),
        new Question("What is the capital of Japan?", ["Beijing", "Tokyo", "Seoul", "Bangkok"], 1),
        new Question("Which instrument has 88 keys?", ["Guitar", "Violin", "Flute", "Piano"], 3),
        new Question("What is the main ingredient in traditional guacamole?", ["Tomato", "Onion", "Avocado", "Lime"], 2),
        new Question("Who was the first person to walk on the Moon?", ["Buzz Aldrin", "Neil Armstrong", "Yuri Gagarin", "Michael Collins"], 1),
        new Question("What is the freezing point of water in Celsius?", ["-10°C", "32°C", "100°C", "0°C"], 3),
        new Question("Which planet is closest to the Sun?", ["Venus", "Earth", "Mercury", "Mars"], 2),
        new Question("What is known as the powerhouse of the cell?", ["Mitochondria", "Nucleus", "Ribosome", "Endoplasmic Reticulum"], 0),
        new Question("Who wrote 'The Odyssey'?", ["Virgil", "Homer", "Sophocles", "Plato"], 1),
        new Question("What is the currency of the United Kingdom?", ["Euro", "Dollar", "Franc", "Pound Sterling"], 3),
        new Question("How many bones are in the adult human body?", ["150", "300", "206", "250"], 2),
        new Question("Which element is a diamond primarily made of?", ["Silicon", "Carbon", "Oxygen", "Boron"], 1),
        new Question("What is the largest desert in the world?", ["Sahara", "Gobi", "Antarctic Desert", "Kalahari"], 2),
        new Question("Who developed the theory of relativity?", ["Isaac Newton", "Galileo Galilei", "Albert Einstein", "Nikola Tesla"], 2),
        new Question("What is the national sport of Canada?", ["Ice Hockey", "Lacrosse", "Baseball", "Both Ice Hockey and Lacrosse"], 3),
        new Question("Which language has the most native speakers in the world?", ["English", "Spanish", "Hindi", "Mandarin Chinese"], 3),
        new Question("What is the capital of Australia?", ["Sydney", "Melbourne", "Canberra", "Brisbane"], 2),
        new Question("Which artist cut off a portion of his own ear?", ["Claude Monet", "Vincent van Gogh", "Pablo Picasso", "Salvador Dalí"], 1),
        new Question("What is the chemical symbol for iron?", ["Fe", "Ir", "In", "I"], 0),
        new Question("How many players are on the field for a soccer team?", ["9", "10", "11", "12"], 2),
        new Question("What is the largest mammal on Earth?", ["African Elephant", "Blue Whale", "Sperm Whale", "Giraffe"], 1),
        new Question("In what year did World War II end?", ["1943", "1945", "1950", "1939"], 1),
        new Question("What is the main component of the sun?", ["Liquid lava", "Molten iron", "Hydrogen", "Oxygen"], 2),
        new Question("Who wrote 'Pride and Prejudice'?", ["Charlotte Brontë", "Jane Austen", "Emily Dickinson", "Virginia Woolf"], 1),
        new Question("What is the capital of Italy?", ["Venice", "Florence", "Milan", "Rome"], 3),
        new Question("Which of these planets has the most moons?", ["Saturn", "Jupiter", "Mars", "Earth"], 0),
        new Question("What is the chemical formula for water?", ["CO2", "H2O", "O2", "NaCl"], 1),
        new Question("Who discovered penicillin?", ["Alexander Fleming", "Louis Pasteur", "Marie Curie", "Albert Einstein"], 0),
        new Question("What is the longest river in the world?", ["Amazon River", "Nile River", "Yangtze River", "Mississippi River"], 1),
        new Question("How many sides does a hexagon have?", ["5", "6", "7", "8"], 1),
        new Question("What is the capital of Canada?", ["Toronto", "Vancouver", "Ottawa", "Montreal"], 2),
        new Question("Which bird is famous for its inability to fly and living in the Southern Hemisphere?", ["Penguin", "Ostrich", "Emu", "Kiwi"], 0),
        new Question("What is the speed of sound in air approximately?", ["343 m/s", "1,200 m/s", "150 m/s", "3,000 m/s"], 0),
        new Question("Who painted 'The Starry Night'?", ["Claude Monet", "Vincent van Gogh", "Pablo Picasso", "Rembrandt"], 1),
        new Question("What is the smallest country in the world by area?", ["Monaco", "Liechtenstein", "Vatican City", "San Marino"], 2),
        new Question("Which element is liquid at room temperature?", ["Mercury", "Gold", "Aluminum", "Copper"], 0),
        new Question("What is the national flower of Japan?", ["Rose", "Cherry Blossom", "Lotus", "Tulip"], 1),
        new Question("Who wrote 'To Kill a Mockingbird'?", ["Harper Lee", "J.D. Salinger", "F. Scott Fitzgerald", "Ernest Hemingway"], 0),
        new Question("What is the capital of Egypt?", ["Alexandria", "Luxor", "Cairo", "Giza"], 2),
        new Question("Which ocean lies between Africa and Australia?", ["Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean"], 2),
        new Question("What is the primary gas found in Earth's atmosphere?", ["Oxygen", "Carbon Dioxide", "Nitrogen", "Hydrogen"], 2),
        new Question("How many players are on a standard basketball team on the court at once?", ["4", "5", "6", "7"], 1),
        new Question("Who invented the telephone?", ["Thomas Edison", "Nikola Tesla", "Alexander Graham Bell", "Guglielmo Marconi"], 2),
        new Question("What is the largest bone in the human body?", ["Tibia", "Femur", "Humerus", "Fibula"], 1),
        new Question("Which country gifted the Statue of Liberty to the United States?", ["United Kingdom", "France", "Spain", "Germany"], 1),
        new Question("What is the capital of Spain?", ["Barcelona", "Valencia", "Madrid", "Seville"], 2),
        new Question("Which chemical element has the symbol 'Na'?", ["Sodium", "Nitrogen", "Neon", "Nickel"], 0),
        new Question("What is the study of weather called?", ["Geology", "Meteorology", "Astronomy", "Biology"], 1),
        new Question("Who wrote '1984'?", ["Aldous Huxley", "George Orwell", "Ray Bradbury", "J.R.R. Tolkien"], 1),
        new Question("What is the tallest mountain in the world above sea level?", ["K2", "Mount Kilimanjaro", "Mount Everest", "Denali"], 2),
        new Question("Which planet is known as the Morning Star or Evening Star?", ["Mars", "Venus", "Mercury", "Saturn"], 1),
        new Question("What is the currency of Japan?", ["Yuan", "Yen", "Won", "Ringgit"], 1),
        new Question("How many teeth does an adult human typically have?", ["28", "30", "32", "34"], 2),
        new Question("Which vitamin is produced when a person is exposed to sunlight?", ["Vitamin A", "Vitamin B12", "Vitamin C", "Vitamin D"], 3),
        new Question("What is the capital of Brazil?", ["Rio de Janeiro", "São Paulo", "Brasília", "Salvador"], 2),
        new Question("Who directed the movie 'Jurassic Park'?", ["James Cameron", "Steven Spielberg", "George Lucas", "Christopher Nolan"], 1),
        new Question("What is the hottest planet in our solar system?", ["Mercury", "Venus", "Mars", "Jupiter"], 1),
        new Question("Which continent is the Sahara Desert located on?", ["Asia", "Australia", "Africa", "South America"], 2),
        new Question("What is the main language spoken in Brazil?", ["Spanish", "Portuguese", "French", "English"], 1),
        new Question("Who wrote 'The Great Gatsby'?", ["Ernest Hemingway", "F. Scott Fitzgerald", "John Steinbeck", "William Faulkner"], 1),
        new Question("What is the square root of 144?", ["10", "11", "12", "14"], 2),
        new Question("Which animal is known as the 'Ship of the Desert'?", ["Horse", "Camel", "Elephant", "Donkey"], 1),
        new Question("What is the capital of Germany?", ["Munich", "Frankfurt", "Berlin", "Hamburg"], 2),
        new Question("Which blood type is known as the universal donor?", ["A", "B", "AB", "O"], 3),
        new Question("What is the primary ingredient in hummus?", ["Chickpeas", "Lentils", "Black Beans", "Soybeans"], 0),
        new Question("Who painted 'The Last Supper'?", ["Michelangelo", "Raphael", "Leonardo da Vinci", "Caravaggio"], 2),
        new Question("What is the freezing point of water in Fahrenheit?", ["0°F", "32°F", "100°F", "212°F"], 1),
        new Question("Which planet has a prominent ring system?", ["Mars", "Saturn", "Neptune", "Mercury"], 1),
        new Question("What is the capital of South Korea?", ["Busan", "Incheon", "Seoul", "Daegu"], 2),
        new Question("Which element's symbol is 'K'?", ["Krypton", "Potassium", "Calcium", "Phosphorus"], 1),
        new Question("Who wrote 'The Hobbit'?", ["C.S. Lewis", "J.R.R. Tolkien", "J.K. Rowling", "Roald Dahl"], 1),
        new Question("What is the largest island in the world?", ["New Guinea", "Borneo", "Greenland", "Madagascar"], 2),
        new Question("Which gas makes up most of the atmosphere of Mars?", ["Oxygen", "Carbon Dioxide", "Nitrogen", "Hydrogen"], 1),
        new Question("What is the capital of India?", ["Mumbai", "New Delhi", "Kolkata", "Bangalore"], 1),
        new Question("Which organ in the human body filters blood?", ["Heart", "Liver", "Kidneys", "Lungs"], 2),
        new Question("What is the national bird of the United States?", ["Bald Eagle", "Golden Eagle", "Peregrine Falcon", "Wild Turkey"], 0),
        new Question("Who formulated the three laws of motion?", ["Albert Einstein", "Isaac Newton", "Galileo Galilei", "Niels Bohr"], 1),
        new Question("What is the capital of Argentina?", ["Buenos Aires", "Cordoba", "Rosario", "Mendoza"], 0),
        new Question("Which metal is the best conductor of electricity?", ["Gold", "Silver", "Copper", "Aluminum"], 1),
        new Question("What is the main pigment used by plants to absorb light for photosynthesis?", ["Carotene", "Chlorophyll", "Xanthophyll", "Anthocyanin"], 1),
        new Question("Who wrote 'The Catcher in the Rye'?", ["J.D. Salinger", "Ernest Hemingway", "Kurt Vonnegut", "Jack Kerouac"], 0),
        new Question("What is the capital of Mexico?", ["Guadalajara", "Cancun", "Mexico City", "Monterrey"], 2),
        new Question("Which U.S. state is known as the Sunshine State?", ["California", "Texas", "Florida", "Arizona"], 2),
        new Question("What is the chemical symbol for table salt?", ["NaCl", "H2O", "CO2", "KCl"], 0),
        new Question("Who was the second President of the United States?", ["Thomas Jefferson", "John Adams", "James Madison", "Benjamin Franklin"], 1),
        new Question("What is the largest planet in our solar system?", ["Saturn", "Jupiter", "Neptune", "Uranus"], 1)
    };

    private record Question(string Text, string[] Options, int CorrectIndex);

    public void Run()
    {
        Console.Write("How many Questions would you like to answer? ");
        string input = Console.ReadLine()?.Trim() ?? string.Empty;

        int amountOfQuestions = Math.Min(int.Parse(input), questions.Count);

        var selectedQuestions = questions.OrderBy(_ => Random.Shared.Next()).Take(amountOfQuestions).ToList();

        int score = 0;

        foreach (var question in selectedQuestions)
        {
            Console.WriteLine(question.Text);

            for (int i = 0; i < question.Options.Length; i++)
            {
                char choiceLetter = (char)('A' + i);
                Console.WriteLine($"  {choiceLetter}. {question.Options[i]}");
            }

            Console.Write("Your answer (A, B, C, D): ");
            input = Console.ReadLine()?.Trim().ToUpper();

            int selectedIndex = input switch
            {
                "A" => 0,
                "B" => 1,
                "C" => 2,
                "D" => 3,
                _ => -1
            };

            if (selectedIndex == question.CorrectIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCorrect!\n");
                Console.ResetColor();
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nIncorrect. The correct answer was {(char)('A' + question.CorrectIndex)}.\n");
                Console.ResetColor();
            }
        }

        Console.WriteLine($"Quiz Over! Your final score: {score}/{amountOfQuestions}");
    }
}
