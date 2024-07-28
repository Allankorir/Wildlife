using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace Wildlife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Lion_Click(object sender, RoutedEventArgs e)
        {
            ShowAnimalDetails(new Animal
            {
                Id = "lion",
                Name = "Lion",
                Headline = "The world's most social felines, lions roam the savannas and grasslands of the African continent, hunting cooperatively and raising cubs in prides.",
                Description = "The lion (Panthera leo) is a species in the family Felidae and a member of the genus Panthera. It is most recognisable for its muscular, deep-chested body, short, rounded head, round ears, and a hairy tuft at the end of its tail. It is sexually dimorphic; adult male lions have a prominent mane. With a typical head-to-body length of 184–208 cm (72–82 in) they are larger than females at 160–184 cm (63–72 in). It is a social species, forming groups called prides. A lion pride consists of a few adult males, related females and cubs. Groups of female lions usually hunt together, preying mostly on large ungulates. The lion is an apex and keystone predator; although some lions scavenge when opportunities occur and have been known to hunt humans, the species typically does not.\n\nTypically, the lion inhabits grasslands and savannas, but is absent in dense forests. It is usually more diurnal than other big cats, but when persecuted it adapts to being active at night and at twilight. In the Pleistocene, the lion ranged throughout Eurasia, Africa and North America, but today it has been reduced to fragmented populations in sub-Saharan Africa and one critically endangered population in western India. It has been listed as Vulnerable on the IUCN Red List since 1996 because populations in African countries have declined by about 43% since the early 1990s. Lion populations are untenable outside designated protected areas. Although the cause of the decline is not fully understood, habitat loss and conflicts with humans are the greatest causes for concern.\n\nOne of the most widely recognised animal symbols in human culture, the lion has been extensively depicted in sculptures and paintings, on national flags, and in contemporary films and literature. Lions have been kept in menageries since the time of the Roman Empire and have been a key species sought for exhibition in zoological gardens across the world since the late 18th century. Cultural depictions of lions were prominent in the Upper Paleolithic period; carvings and paintings from the Lascaux and Chauvet Caves in France have been dated to 17,000 years ago, and depictions have occurred in virtually all ancient and medieval cultures that coincided with the lion's former and current ranges.",
                Facts = new[]
                {
                    "Female lions raise the cubs and are also the primary hunters.",
                    "Lions are the only cats that live in groups. A pride, can be up to 30 lions, depending on how much food and water is available.",
                    "Without their coats, lion and tiger bodies are so similar that only experts can tell them apart."
                },
                ImagePath = "Resources/cover-lion.jpg"
            });
        }
        private void Cheetah_Click(object sender, RoutedEventArgs e)
        {
            ShowAnimalDetails(new Animal
            {
                Id = "cheetah",
                Name = "Cheetah",
                Headline = "The cheetah is the fastest land animal in the world, reaching speeds of up to 70 miles per hour. They can accelerate from 0 to 68 miles per hour in just three seconds.",
                Description = "The cheetah is a large cat native to Africa and central Iran. It is the fastest land animal, capable of running at 80 to 128 km/h (50 to 80 mph), and as such has several adaptations for speed, including a light build, long thin legs and a long tail. Cheetahs typically reach 67–94 cm (26–37 in) at the shoulder, and the head-and-body length is between 1.1 and 1.5 m (3.6 and 4.9 ft). Adults typically weigh between 20 and 65 kg (44 and 143 lb). Its head is small, rounded, and has a short snout and black tear-like facial streaks. The coat is typically tawny to creamy white or pale buff and is mostly covered with evenly spaced, solid black spots. Four subspecies are recognised.\n\nMore gregarious than many other cats, the cheetah has three main social groups—females and their cubs, male \"coalitions\" and solitary males. While females lead a nomadic life searching for prey in large home ranges, males are more sedentary and may instead establish much smaller territories in areas with plentiful prey and access to females. The cheetah is active mainly during the day and hunting is its major preoccupation, with peaks during dawn and dusk. It feeds on small- to medium-sized prey, mostly weighing under 40 kg (88 lb), and prefers medium-sized ungulates such as impala, springbok and Thomson's gazelles. The cheetah will typically stalk its prey to within 60–70 m (200–230 ft), charge towards it, trip it during the chase and bite its throat to suffocate it to death. Breeding occurs throughout the year; after a gestation of nearly three months a litter of typically three to five cubs is born; cheetah cubs are highly vulnerable to predation by other large carnivores such as hyenas and lions. Weaning happens at around four months, and cubs are independent by around 20 months of age.\n\nThe cheetah occurs in a variety of habitats such as savannahs in the Serengeti, arid mountain ranges in the Sahara and hilly desert terrain in Iran. The cheetah is threatened by several factors such as habitat loss, conflict with humans, poaching and high susceptibility to diseases. Earlier ranging throughout most of Sub-Saharan Africa and extending eastward into the Middle East up to the Indian subcontinent, the cheetah is now distributed mainly in small, fragmented populations in central Iran and southern, eastern and northwestern Africa. In 2016, the global cheetah population was estimated at around 7,100 individuals in the wild; it is listed as Vulnerable on the IUCN Red List. In the past, cheetahs used to be tamed and trained for hunting ungulates. They have been widely depicted in art, literature, advertising, and animation.",
                Facts = new[]
                {
                    "The black ‘tear tracks’ that line a cheetah’s face prevent the sun from infiltrating and blinding the animal whilst hunting.",
                    "The cheetah is the fastest land animal in the world, reaching speeds of up to 113km/h.",
                    "They can accelerate from 0 to 100km/h in just 3 seconds."
                },
                ImagePath = "Resources/cover-cheetah.jpg"
            });
        }
        private void Buff_Click(object sender, RoutedEventArgs e)
        {
            ShowAnimalDetails(new Animal
            {
                Id = "buffalo",
                Name = "African buffalo",
                Headline = "The African Buffalo is a bovine species that is widely spread across Africa. It belongs to the famous \"Big Five\". Usually, African buffaloes form large herds.",
                Description = "The African buffalo or Cape buffalo is a large sub-Saharan African bovine. Cape buffalo, is the typical subspecies, and the largest one, found in Southern and East Africa. S. c. nanus (the forest buffalo) is the smallest subspecies, common in forest areas of Central and West Africa, while S. c. brachyceros is in West Africa and S. c. aequinoctialis is in the savannas of East Africa. The adult African buffalo's horns are its characteristic feature: they have fused bases, forming a continuous bone shield across the top of the head referred to as a \"boss\". They are widely regarded as among the most dangerous animals on the African continent, and according to some estimates they gore, trample, and kill over 200 people every year.\n\nThe African buffalo is not an ancestor of domestic cattle and is only distantly related to other larger bovines. Its unpredictable temperament means that the African buffalo has never been domesticated, unlike its Asian counterpart, the water buffalo. African buffaloes have few predators aside from lions and large crocodiles. As a member of the big five game, the Cape buffalo is a sought-after trophy in hunting.\n\nThe African buffalo is a very robust species. Its shoulder height can range from 1.0 to 1.7 m (3.3 to 5.6 ft) and its head-and-body length can range from 1.7 to 3.4 m (5.6 to 11.2 ft). Compared with other large bovids, it has a long but stocky body (the body length can exceed the wild water buffalo, which is heavier and taller) and short but thickset legs, resulting in a relatively short standing height. The tail can range from 70 to 110 cm (28 to 43 in) long. Savannah-type buffaloes weigh 500 to 1,000 kg (1,100 to 2,200 lb), with males normally larger than females, reaching the upper weight range.[3] In comparison, forest-type buffaloes, at 250 to 450 kg (600 to 1,000 lb), are only half that size.[4][5] Its head is carried low; its top is located below the backline. The front hooves of the buffalo are wider than the rear, which is associated with the need to support the weight of the front part of the body, which is heavier and more powerful than the back.\n\nSavannah-type buffaloes have black or dark brown coats with age. Old bulls often have whitish circles around their eyes and on their face. Females tend to have more-reddish coats. Forest-type buffaloes are 30-40% smaller, reddish brown in colour, with much more hair growth around the ears and with horns that curve back and slightly up. Calves of both types have red coats.",
                Facts = new[]
                {
                    "Buffalo are actually fantastic swimmers. They will swim through deep waters to find better grazing areas.",
                    "We refer to them as the mafia, not only because of their strong character but because they never forgive and almost always seek revenge.",
                    "African buffalo have a complex social structure based on what scientists call a “dominance hierarchy”."
                },
                ImagePath = "Resources/cover-buffalo.jpg"
            });
        }
        private void Elephant_Click(object sender, RoutedEventArgs e)
        {
            ShowAnimalDetails(new Animal
            {
                Id = "elephant",
                Name = "Elephant",
                Headline = "Elephants are the largest land mammals on earth and have distinctly massive bodies, large ears, and long trunks. They use their trunks to pick up objects, trumpet warnings, greet other elephants, or suck up water for drinking or bathing, among other uses.",
                Description = "Elephants are mammals of the family Elephantidae and the largest existing land animals. Three species are currently recognised: the African bush elephant, the African forest elephant, and the Asian elephant. Elephantidae is the only surviving family of the order Proboscidea; extinct members include the mastodons. The family Elephantidae also contains several now-extinct groups, including the mammoths and straight-tusked elephants. African elephants have larger ears and concave backs, whereas Asian elephants have smaller ears, and convex or level backs. Distinctive features of all elephants include a long trunk, tusks, large ear flaps, massive legs, and tough but sensitive skin. The trunk, also called a proboscis, is used for breathing, bringing food and water to the mouth, and grasping objects. Tusks, which are derived from the incisor teeth, serve both as weapons and as tools for moving objects and digging. The large ear flaps assist in maintaining a constant body temperature as well as in communication. The pillar-like legs carry their great weight.\\n\\nElephants are scattered throughout sub-Saharan Africa, South Asia, and Southeast Asia and are found in different habitats, including savannahs, forests, deserts, and marshes. They are herbivorous, and they stay near water when it is accessible. They are considered to be keystone species, due to their impact on their environments. Other animals tend to keep their distance from elephants; the exception is their predators such as lions, tigers, hyenas, and wild dogs, which usually target only young elephants (calves). Elephants have a fission–fusion society, in which multiple family groups come together to socialise. Females (cows) tend to live in family groups, which can consist of one female with her calves or several related females with offspring. The groups, which do not include bulls, are led by the (usually) oldest cow, known as the matriarch.\\n\\nMales (bulls) leave their family groups when they reach puberty, and may live alone or with other males. Adult bulls mostly interact with family groups when looking for a mate. They enter a state of increased testosterone and aggression known as musth, which helps them gain dominance over other males as well as reproductive success. Calves are the centre of attention in their family groups and rely on their mothers for as long as three years. Elephants can live up to 70 years in the wild. They communicate by touch, sight, smell, and sound; elephants use infrasound, and seismic communication over long distances. Elephant intelligence has been compared with that of primates and cetaceans. They appear to have self-awareness, as well as appearing to show empathy for dying and dead family members.\\n\\nAfrican elephants are listed as vulnerable and Asian elephants as endangered by the International Union for Conservation of Nature (IUCN). One of the biggest threats to elephant populations is the ivory trade, as the animals are poached for their ivory tusks. Other threats to wild elephants include habitat destruction and conflicts with local people. Elephants are used as working animals in Asia. In the past, they were used in war; today, they are often controversially put on display in zoos, or exploited for entertainment in circuses. Elephants are highly recognisable and have been featured in art, folklore, religion, literature, and popular culture.",
                Facts = new[]
                {
                     "Elephants can recognize themselves in the mirror. They join humans, apes, and dolphins as the only animals with self-awareness.",
                     "Female elephants have the longest pregnancy of any mammal. It’s a lengthy 22 months before baby elephants are ready to be born.",
                     "Elephants make sounds that we can’t even hear. Some of their calls are so low, they are below the range of human hearing."
                },
                ImagePath = "Resources/cover-elephant.jpg"
            });
        }
        private void Giraffe_Click(object sender, RoutedEventArgs e)
        {
            ShowAnimalDetails(new Animal
            {
                Id = "giraffe",
                Name = "Giraffe",
                Headline = "At an average height of around 5 m (16-18 ft.), the giraffe is the tallest land animal in the world. Giraffes live primarily in savanna areas in the sub-Saharan region of Africa.",
                Description = "The giraffe is an African artiodactyl mammal, the tallest living terrestrial animal and the largest ruminant. It is traditionally considered to be one species, Giraffa camelopardalis, with nine subspecies. However, the existence of up to eight extant giraffe species has been described, based upon research into the mitochondrial and nuclear DNA, as well as morphological measurements of Giraffa. Seven other species are extinct, prehistoric species known from fossils.\n\nThe giraffe's chief distinguishing characteristics are its extremely long neck and legs, its horn-like ossicones, and its distinctive coat patterns. It is classified under the family Giraffidae, along with its closest extant relative, the okapi. Its scattered range extends from Chad in the north to South Africa in the south, and from Niger in the west to Somalia in the east. Giraffes usually inhabit savannahs and woodlands. Their food source is leaves, fruits and flowers of woody plants, primarily acacia species, which they browse at heights most other herbivores cannot reach. They may be preyed on by lions, leopards, spotted hyenas and African wild dogs. Giraffes live in herds of related females and their offspring, or bachelor herds of unrelated adult males, but are gregarious and may gather in large aggregations. Males establish social hierarchies through \"necking\", which are combat bouts where the neck is used as a weapon. Dominant males gain mating access to females, which bear the sole responsibility for raising the young.\n\nThe giraffe has intrigued various cultures, both ancient and modern, for its peculiar appearance, and has often been featured in paintings, books, and cartoons. It is classified by the International Union for Conservation of Nature as vulnerable to extinction, and has been extirpated from many parts of its former range. Giraffes are still found in numerous national parks and game reserves but estimates as of 2016 indicate that there are approximately 97,500 members of Giraffa in the wild. More than 1,600 were kept in zoos in 2010.",
                Facts = new[]
                {
                     "Giraffes only need 5 to 30 minutes of sleep in a 24-hour period! They often achieve that in quick naps that may last only a minute or two at a time.",
                     "They can run as fast as 35 miles an hour over short distances, or cruise at 10 mph over longer distances.",
                     "Within just 10 hours of their birth, baby giraffes can run with their families without struggling."
                },
                ImagePath = "Resources/cover-giraffe.jpg"
            });
        }
        private void ShowAnimalDetails(Animal animal)
        {
            animalImage.Source = new BitmapImage(new Uri(animal.ImagePath, UriKind.Relative));
            animalName.Text = animal.Name;
            animalHeadline.Text = animal.Headline;
            animalDescription.Text = animal.Description;
            animalFacts.Children.Clear();
            foreach (var fact in animal.Facts)
            {
                animalFacts.Children.Add(new TextBlock { Text = fact, FontSize = 14, Margin = new Thickness(0, 5, 0, 0) });
            }
        }

        public class Animal
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Headline { get; set; }
            public string Description { get; set; }
            public string[] Facts { get; set; }
            public string ImagePath { get; set; }
        }
    }
}