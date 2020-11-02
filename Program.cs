using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

// Written & Created by Sehun Babatunde :)

namespace Isaaza
{
    class Program
    {
        static void StoryMethod()
        {
            Console.WriteLine("              Isaaza");
            Console.ReadLine();
            Console.WriteLine(); //Blank print for some nice space between the title.
            Console.WriteLine("Written & Created by Sehun Babatunde :)");
            Console.WriteLine(); //Blank print for some nice space between the title.
            Console.WriteLine("Please Note: You may need to scroll back up, to make sure you don't miss any text. Thank you, enjoy!");
            Console.WriteLine(); //Blank print for some nice space between the title.
            Console.WriteLine(); //Blank print for some nice space between the title.
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What would you do if your beloved food was banned?");
            Console.ReadLine();
            Console.WriteLine("What lengths would you go to get another taste?");
            Console.ReadLine();
            Console.WriteLine("They’re not exactly drugs, right?");
            Console.ReadLine();
            Console.WriteLine("Well, for 24-year-old Isaac Harris, he might go the full run.");
            Console.ReadLine();

            Console.WriteLine(); //Blank print for some nice space.
            Console.WriteLine("In the late evening of another meek day in Larsham, standing outside of a shopping centre.");
            Console.ReadLine();
            Console.WriteLine("We have our young hero; Isaac dressed in his usual casual clothing, complete with his trusty bucket hat which he can’t leave home without.");
            Console.ReadLine();
            Console.WriteLine("Trying his best to look inconspicuous, though with an anxious look lumped on his face.");

            Console.WriteLine(); //Blank print for some nice space.
            Console.WriteLine("As he looked around at the gapped lines of crossing people, he notices next to the automatic shop entrance, was a poised but vigilant young man leaning against a brick wall.");
            Console.ReadLine();
            Console.WriteLine("The man stood as a watchful observer carefully scanning passers-by walking by and out of the centre whilst vaping all in a mechanical order.");

            Console.WriteLine(); //Blank print for some nice space.
            Console.WriteLine("As Isaac headed towards the mysterious figure, during his attentive scan through people passing him, he gazes in Isaac’s direction for a few seconds and turns down the alleyway.");
            Console.ReadLine();
            Console.WriteLine("Isaac seeing this treads behind the man through the litter-ridden alleyway, while still trying to play it cool.");
            Console.ReadLine();
            Console.WriteLine("The man halts in the middle of the alleyway, turning around to lean against a wall whilst taking a last look around, and another draw of his vape.");

            Console.WriteLine(); //Blank print for some nice space.
            Console.WriteLine("With Isaac beside him he utters, \"So, this is where you do business.” ");
            Console.ReadLine();
            Console.WriteLine("The man turns to him channelling his vigilance into his tone says “Hands up.” ");
            Console.ReadLine();
            Console.WriteLine(); //Blank print for some nice space.
            Console.ReadLine();
            Console.WriteLine("Isaac immediately responding to his instruction pushes his stomach to the wall. With the man proceeds to hover his hands on him from top to bottom.");

            Console.WriteLine(); //Blank print for some nice space.
            Console.WriteLine("CHOOSE YOUR CHOICE");
            Console.WriteLine("1. “Woah, I’m just here for the stuff.”");
            Console.WriteLine("2. “Do I have to strip too?”");
            Console.WriteLine("Choose & enter 1 or 2");
            String finalChoice;
            finalChoice = Console.ReadLine();



            String choice2 = "“Not, interested buddy.” ";
            String choice3 = "Big mistake. " +
                "The man slides out a baton from his the side of his jacket and rapidly whips it on Isaac’s skull, you could hear a big clunk sound, with Isaac effortlessly dropping to the ground, blacked out.";


            //Input Validation if the user does not put in the given values it won't continue the game till they do.
            while (finalChoice != "1" && finalChoice != "2")
            {
                Console.WriteLine("Sorry, you must enter '1' or '2'.");
                Console.WriteLine("CHOOSE YOUR CHOICE");
                Console.WriteLine("1. “Woah, I’m just here for the stuff.”");
                Console.WriteLine("2. “Do I have to strip too?”");
                Console.WriteLine("Choose & enter 1 or 2");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("As the man performs his aggressive pat down on him he throws in");
                Console.WriteLine("\"You told anyone, about our little meeting?\"");
                Console.WriteLine("Were you followed?");
            }

            else if (finalChoice == "2")
            {
                Console.WriteLine();
                Console.WriteLine(choice2 + "As the man performs his aggressive pat down on him he throws in \"You told anyone, about our little meeting?");
                Console.WriteLine("\"Were you followed?\"");
            }


            Console.ReadLine();
            Console.WriteLine("CHOOSE YOUR CHOICE :)");
            Console.WriteLine("1. “No and no. You can trust me.\"");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1")
            {
                Console.WriteLine("Sorry, you must enter '1' to continue.");
                Console.WriteLine("CHOOSE YOUR CHOICE :)");
                Console.WriteLine("1. “No and no. You can trust me.\"");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine("The man reaches back up and leans his back against the alleyway’s wall, opposite to Isaac.");
                Console.WriteLine(); //Blank print for some nice space
                Console.WriteLine("“Sorry, just protocol. They’ve been cracking down on us, hard lately.”");
                Console.WriteLine(); //Blank print for some nice space
                Console.WriteLine("The man wiggles his hand back into his pockets and pulls back out his vape stick.");
                Console.WriteLine(); //Blank print for some nice space
                Console.WriteLine("“So what you here for?”");
            }

            Console.WriteLine(); //Blank print for some nice space
            Console.ReadLine();

            Console.WriteLine("Isaac’s eyes widen as he says “I heard you can get things… illegal things.”");
            Console.WriteLine(); //Blank print for some nice space
            Console.WriteLine("The man blows out another cloud of vape as he utters “Like what?”");
            Console.WriteLine(); //Blank print for some nice space
            Console.WriteLine("“Like Pizza.”");
            Console.WriteLine(); //Blank print for some nice space
            Console.WriteLine("“Damn, why didn’t you say so?”");
            Console.WriteLine(); //Blank print for some nice space
            Console.ReadLine();

            Console.WriteLine("Just after the man, finishes his last words. He reaches into his jacket and pulls out a series of zipped up plastics bags.");
            Console.ReadLine();
            Console.WriteLine("Each with varying colours of grounded up powder, from light oranges to grassy green, each bag, marked with their name in a bold marker pen.");
            Console.ReadLine();
            Console.WriteLine("\"I got Capricciosa, Grandiosa, Hawaiian, I won’t judge you.");
            Console.ReadLine();
            Console.WriteLine("I have Africana and our customer favourite Margherita, take your pick.");
            Console.ReadLine();
            Console.WriteLine("Heck, I got more in the car.”");

            Console.WriteLine(); //Blank print for some nice space.
            Console.WriteLine("“What the hell are those?”");
            Console.ReadLine();
            Console.WriteLine("“It’s Pozza.”");
            Console.ReadLine();
            Console.WriteLine("“What the hell is it?");
            Console.ReadLine();
            Console.WriteLine("“It’s the next best thing, well its powdered pizza; you think we’ll be carrying pizza boxes everywhere?");
            Console.ReadLine();
            Console.WriteLine("The damn powers that be, would be on us in minutes!” ");
            Console.WriteLine(); //Blank print for some nice space
            Console.ReadLine();


            Console.WriteLine("Choose & enter 1 or 2");
            Console.WriteLine("1. \"That’s not gonna cut it, the real thing please.");
            Console.WriteLine("2. “Sorry! I sold you out to them for a lifetime supply of BBQ and beer”");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2")
            {
                Console.WriteLine("Choose & enter 1 or 2");
                Console.WriteLine("1. \"That’s not gonna cut it, the real thing please.");
                Console.WriteLine("2. “Sorry! I sold you out to them for a lifetime supply of BBQ and beer”");
                finalChoice = Console.ReadLine();
            }


            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("The man stuffs the grounded up powder bags of “Pozza” back into his jacket pockets, takes a quick look around, and leans into Isaac");
                Console.WriteLine("“We charge extra for the real stuff.”");

            }
            else if (finalChoice == "2") //Game Over & Closes the program
            {
                Console.Clear();
                Console.WriteLine("\"What?!" + "“Hold on, I was joking!”");
                Console.WriteLine(choice3);
                Console.WriteLine();
                Console.WriteLine("                  GAME OVER");
                Console.WriteLine("Damn don’t mess with Pozza dealers, try again?");
                Console.WriteLine("Enter “Y“ to play again or “N“ to quit");
                string userInput;
                userInput = Console.ReadLine();

                while (userInput != "y" && userInput != "n" && userInput != "Y" && userInput != "N" && userInput != "yes" && userInput != "Yes" && userInput != "YES" && userInput != "no" && userInput != "No" && userInput != "NO") // Input validation 
                {
                    Console.WriteLine("Please Enter “Y“ to play again or “N“ to quit");
                    userInput = Console.ReadLine();
                }
                
                if ( userInput == "y" || userInput == "Y" || userInput == "yes" || userInput == "Yes" || userInput == "YES")
                {
                    Console.WriteLine("There you go, keep going!");
                    Console.ReadLine();
                    Console.Clear();
                    RestartStoryMethod();

                }

               else if (userInput == "n" || userInput == "N" || userInput == "no" || userInput == "No" || userInput == "NO")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    return;

                }





            }


            Console.WriteLine("CHOOSE YOUR CHOICE :) ;)");
            Console.WriteLine("1. “If you have it, I’ll pay.”");
            finalChoice = Console.ReadLine();


            while (finalChoice != "1")
            {
                Console.WriteLine("Sorry, you must enter '1' to continue.");
                Console.WriteLine("CHOOSE YOUR CHOICE :) ;)");
                Console.WriteLine("1. “If you have it, I’ll pay.”");
                finalChoice = Console.ReadLine();

            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("“I’ll take you to a place.”");

            }

            Console.WriteLine("The man with Isaac a few meters behind knocks on a big metal door five times, each with a gap in the middle.");
            Console.ReadLine();
            Console.WriteLine("After a short wait, a gruff voice growls an instruction behind it.");
            Console.ReadLine();

            Console.WriteLine("“Who is it?”");
            Console.ReadLine();
            Console.WriteLine("“It’s Bence, open up.”");
            Console.ReadLine();

            Console.WriteLine("A long peep-hole stretches open with a long screech, revealing two large eyes rotating back and forth to Bence and Isaac.");
            Console.ReadLine();
            Console.WriteLine("With the peephole screeching back closed, the big metal door clanks open, inviting them in.");
            Console.ReadLine();
            Console.WriteLine("Bence opening his arms chirped “Hey.”");
            Console.ReadLine();
            Console.WriteLine("“Boss, said not to bring customers.” insinuated by the big eyed man, scanning Isaac up and down.");

            Console.ReadLine();
            Console.WriteLine("“Don’t worry, I’ve checked him, he’s also got extra.”");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Inside, was like coming to a mansion after a bad day at work.");
            Console.ReadLine();
            Console.WriteLine("Inside was a completing different atmosphere from the outside, with beautiful paintings of various probably famous artists gracing the walls."); 
            Console.WriteLine("A warm rustic vintage feel to it and finished with a candle lit atmosphere.");
            Console.ReadLine();
            Console.WriteLine("With Isaac following Bence, they both head down some stairs, to reveal a lower level of a long corridor of open area.");
            Console.ReadLine();
            Console.WriteLine("Out of the open doors, there were people dressed in white outfits with various sauce stains.");
             Console.WriteLine("And people with rugged winter clothing holding rifles crisscrossing out of the open doorways.");
            Console.ReadLine();
            Console.WriteLine("With the inviting aroma of that golden-yellow cheesy, mouth-watering glorious oven baked goodness he calls pizza.");
            Console.ReadLine();
            Console.WriteLine("Isaac knew he was at home.");
            Console.ReadLine();
            Console.WriteLine("There was a warming sense of hope, seeing an obvious beacon of culture still surviving in these harsh times.");
            Console.ReadLine();
            Console.WriteLine();


            Console.ReadLine();
            Console.WriteLine("Bence entering one of the rooms knocks him out of his daydream, as he stretches out his arm and hand to Isaac saying “Money please.”");

            Console.ReadLine();
            Console.WriteLine("1.(“Hand him £100 of pizza money”)\"");
            Console.WriteLine("CHOOSE YOUR CHOICE :)");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1")
            {
                Console.WriteLine("Sorry, you must enter '1' to continue");
                Console.WriteLine("1. (“Hand him £100 of pizza money”)\"");
                Console.WriteLine("CHOOSE YOUR CHOICE :)");
                finalChoice = Console.ReadLine();
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Bence taking his money enters a large room with a large black block in the corner.");
            Console.WriteLine("He rotates a dial a few times opening it, revealing overflowing stacks of paper money and pounds in it.");
            Console.WriteLine("adding Isaac’s money to the ever-growing pile, and then shutting it.");
            Console.ReadLine();
            Console.WriteLine("He then drops himself in a beaten up red armchair, pushes his streaks of black hair back and draws up more vape from his pen.");
            Console.ReadLine();
            Console.WriteLine("But with heated sounds coming from the open room, Isaac, with his curiosity, wanders in.");
            Console.ReadLine();
            Console.WriteLine("Revealing two shouting heads at opposite ends of a round table, with a set of people being closer to one end nodding along and the other set at the other.");


            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("“I’m sick of doing this in secret. We need to do something!”");
            Console.ReadLine();
            Console.WriteLine("“The Innami will—”");
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("“FUCK the Innami!  What are they going to do?”");
            Console.ReadLine();
            Console.WriteLine("Bence sunk into the chair and blowing away snaps up his head to the table and nods at Isaac.");
            Console.ReadLine();
            Console.WriteLine("He sneers “Daniel, Kaie, stop bickering, we got a customer.”");
            Console.ReadLine();
            Console.WriteLine("Daniel flexing his back and neck to him. “Can’t, you see we’re busy?”");
            Console.ReadLine();
            Console.WriteLine("“No, we’re done here. We are not going at the Innami.” declared by the opposing Kaie rising up from his chair.");
            Console.ReadLine();
            Console.WriteLine("Ear piercing gunfire, yelling and rapid footsteps all hammer the room from above.");

            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("“What the — How did they find us? Were you followed?!” growled by Daniel jumping from his chair as he switches his attention to the ceiling and back at Bence.");
            Console.ReadLine();
            Console.WriteLine("“No, I made sure of it.”  A perplexed Bence states to him.");

            Console.ReadLine();
            Console.WriteLine("“Not the time, Daniel.” back at him by Kaie.");
            Console.ReadLine();
            Console.WriteLine("Kaie looking at the other members at the table says. “Get the weapons, Bence get the money.”");


            Console.ReadLine();
            Console.WriteLine("Isaac standing in the midst of the entire rumble blurts:");
            Console.ReadLine();
            Console.WriteLine("1.“I just wanted the pizza… how the hell we getting out of here?”");
            Console.WriteLine("2.“Y'all screwed; they’re all after you, not me.”");
            Console.WriteLine("CHOOSE YOUR CHOICE");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2")
            {
                Console.WriteLine("Sorry, you must enter '1' or '2'.");
                Console.WriteLine("1.“I just wanted the pizza… how the hell we getting out of here?”");
                Console.WriteLine("2.“Y'all screwed; they’re all after you, not me.”");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("“Grab a gun and move.”");
            }

            else if (finalChoice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("They’re not going to be to entirely forgiving, of someone trying to buy an illegal substance, you’re just as bad in their eyes.”");
                Console.WriteLine("“Better chances with us.” Daniel, reassuring him.");
              
            }

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("The group of people thrust the table forward and rip open the floorboards revealing a hole littered with rifles and pistols and plenty of magazines."); 
            Console.WriteLine("Each person grabbing one, passing them along to each other and cocking them in a rapid succession.");
            Console.ReadLine();
            Console.WriteLine("While Bence hastily opens back up the safe, and rattles a big gym bag, sliding and stuffing the piles of money notes and pounds into it."); 
            Console.WriteLine("It was so fast it was like a bank robbery and slinging it on his back.");
            Console.ReadLine();
            Console.WriteLine("Kaie, with his arm extended to Isaac with a pistol and a magazine, gripped in his hand “You ever used one before?”");

            Console.ReadLine();
            Console.WriteLine("1.“No.”");
            Console.WriteLine("2.“Yeah, I use it them all the time, killing people left and right.”");
            Console.WriteLine("CHOOSE YOUR CHOICE :)");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2")
            {
                Console.WriteLine("Sorry, you must enter '1' or '2'.");
                Console.WriteLine("1.“No.”");
                Console.WriteLine("2.“Yeah, I use it them all the time, killing people left and right.”");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("“Well, this is practice time. Point and shoot for the best. Empty? Press this on the grip, put another in and pull the slide back. Got it?");
            }

           else if (finalChoice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("“Well, you must be an expert then. Point and shoot for the best.");
                Console.WriteLine("“Empty?“");
                Console.WriteLine("“Press this on the grip, put another in with the bullets and pull the slide back.“");
                Console.WriteLine("“Got it?“");
            }

            Console.ReadLine();
            Console.WriteLine("Isaac staring at the pistol like a screaming baby places his hand on the cold hard grip, taking it from him and cocks the pistol, ready to fight.");
            Console.ReadLine();
            Console.WriteLine("“Alright, everyone on me.” ");
            Console.ReadLine();
            Console.WriteLine("”Bence, leaning behind the wall pistol in one hand, pokes his head out the hallway.”");
            Console.ReadLine();
            Console.WriteLine("To see an army of pitch black, masked and heavily armed to the helmet wearing foot soldiers.");
            Console.WriteLine("With the words “POLICE” stamped on their body armour, rapidly marching down the hallway to invade their hideout.");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Sinking into the wall, he silently screams, bringing his pistol next to his head.");
            Console.WriteLine("“They are coming down.”");
            Console.WriteLine("His eyes darted towards Kaie. “Kaie, how should we play this?”");
            Console.ReadLine();
            Console.WriteLine("“We leg it to the van,” A similar energetic Daniel replies.");
            Console.WriteLine("Bence looks around the room to the group, whispering “We move on… 1…2—“");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bence jerks out the room, sprinting down the endless hallway along with the group behind him.");
            Console.WriteLine("With the SWAT team spotting them, giving chase. Now with Isaac a new passenger trailing behind them.");
            Console.WriteLine("Now with Isaac a new passenger trailing behind them.");
            Console.WriteLine("An unhelmeted man in front of the team screams “Get them!” As they sprint down.");
            Console.ReadLine();
            Console.WriteLine("In the distance of the seemingly endless hallway lied a big grey vault door, behind it being opened by a member of the dealers’ crew.");
            Console.ReadLine();
            Console.WriteLine("“Come quick!” as he comes out, firing relentlessly at the SWAT Team.");
            Console.ReadLine();
            Console.WriteLine("The crew make it to the door with Bence and Kaie sliding to safety while the other members crouch in front, blasting away at the incoming threats.");
            Console.ReadLine();
            Console.WriteLine("But a chasing swat member shoots a fiery bullet speeding straight into Daniel’s leg just as he reaches to enter through.");

            Console.ReadLine();
            Console.WriteLine("He lets out a “Fuck!” With his leg in the air jolting his whole body to the floor.");
            Console.ReadLine();
            Console.WriteLine("Isaac stopping in the track sees this and:");


            Console.ReadLine();
            Console.WriteLine("1.(Help him up)");
            Console.WriteLine("CHOOSE YOUR CHOICE :)");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1")
            {
                Console.WriteLine("Sorry, you must enter '1' to continue");
                Console.WriteLine("1.(Help him up)");
                Console.WriteLine("CHOOSE YOUR CHOICE :)");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("“These pricks got my leg!” shouted Daniel as Isaac picks him up by his shoulder, while he limps to the safe haven.");

            }

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("And with Bence pushing the door with his back, shutting it to the ongoing gunfire.");
            Console.ReadLine();
            Console.WriteLine("“It’s only us left…”");
            Console.ReadLine();
            Console.WriteLine("Daniel says limping forward with his eyes lowered to the bottom to the floor."); 
            Console.WriteLine("His body heated up from the pain and face all clenched up “I swear they’re going to get it.”");
            Console.ReadLine();
            Console.WriteLine("“Van’s up above. Can’t give up now,” Bence replies bringing his head back up to his level with a warming tone.");
            Console.ReadLine();
            Console.WriteLine("Daniel shifts his body and eyes towards Isaac, now with the tightness in his face smoothed out.");
            Console.ReadLine();
            Console.WriteLine("“This guy, you bought back… saved my damn life. Thank you.”");
            Console.ReadLine();
            Console.WriteLine("The whole room turned to Isaac for a moment. His cheeks brightening to a tomato red and he stood up a little taller.");
            Console.ReadLine();
            Console.WriteLine("Outside the gunfire came to a halt to a repeated thump shaking the door.");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("“We’re not free yet, come on.“ Kaie utters readdressing the group and rushing over the room."); 
            Console.WriteLine("Crouching down to open up a piece of the floor to a floor below.");
            Console.ReadLine();
            Console.WriteLine("And a ladder bar at the top on which he makes his way down.");
            Console.ReadLine();
            Console.WriteLine("“Last person, slide the floor back and do it quickly!“  He says then making his way down and then Bence and Daniel going down after him.");
            Console.ReadLine();
            Console.WriteLine("Then finally Isaac crouches down putting his feet on the lower ladder bars, holding onto the top of the first ladder bar pulls and slides the above floorboard back.");

            Console.ReadLine();
            Console.WriteLine("Closing off the light from above, then makes his way down his way down."); 
            Console.WriteLine("To reveal a short and narrow corridor with a long rusted dirty ladder at the end.");
            Console.ReadLine();
            Console.WriteLine("Kaie at the top of the ladder opens a metal hatch door on to reveal a gap of light, which he and Bence go through.");

            Console.ReadLine();
            Console.WriteLine("From above he crouches down to shout “Grab my hand,”");
            Console.WriteLine("Kaie grabbing Daniel’s hands, pulling him up, while Isaac pushes him up from below."); 
            Console.WriteLine("Then Isaac follows up after, closing the hatch door, with them reaching an indoor car park.");
            Console.ReadLine();
            Console.WriteLine("“Over here.” Kaie whispers to Isaac as he sneaks over to see him and Bence crouched, peaking through the window and Daniel lying down behind a parked up car.");
            Console.ReadLine();
            Console.WriteLine("With the van a few meters parked in the distance.");
            Console.ReadLine();
            Console.WriteLine("Passing the van, were two men dressed in all black gear, zipped up jackets walkie-talkies on their shoulders and shiny silver badges on their curved black hats.");
            Console.ReadLine();
            Console.WriteLine("“You see those two guys over there.” Kaie whispered.");
            Console.ReadLine();
            Console.WriteLine("Isaac snapping his neck with a longer than usual look at the officers and then back at Kaie, swallowing his throat. “Yeah.”");

            Console.ReadLine();
            Console.WriteLine("“You gotta distract them, then me and Bence will do the rest.");
            Console.ReadLine();
            Console.WriteLine("As Isaac proceeds to stand up, Kaie moves his hand onto Isaac’s leg, stopping him in mid-motion");
            Console.WriteLine("“Aye, play it cool alright, we don’t want you getting shot.”");
            Console.ReadLine();
            Console.WriteLine("Isaac takes slow steps forward and then begins to pick up the cycle, walking forward in the sight of the two officers.");
            Console.ReadLine();
            Console.WriteLine("“We’ll ask this guy.” muttered by the left officer to the right, moving forward to approach Isaac.");
            Console.ReadLine();
            Console.WriteLine("“Eh, mate you seen these three faces about?”");
            Console.WriteLine("The officer on the right pulls out of his pocket; a piece of paper of separates long shots of Bence, Kaie and Daniel in public.");
            Console.ReadLine();
            Console.WriteLine("“These are three very dangerous criminals, we have reports that they are currently in the proximity” said immediately after the first officer.");


            Console.ReadLine();
            Console.WriteLine("1.“No, sorry I haven’t seen them.”");
            Console.WriteLine("2.(Say Nothing)");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2")
            {
                Console.WriteLine("Sorry, you must enter '1' or '2'.");
                Console.WriteLine("1.“No, sorry I haven’t seen them.”");
                Console.WriteLine("2.(Say Nothing)");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("With the officer’s eyes squinting at each other and at Isaac");
                Console.WriteLine("“You look a little roughed up mate, you sure you don’t know anything…”");

            }

            else if (finalChoice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("With the officer’s eyes squinting at each other and at Isaac");
                Console.WriteLine("“Sir, you okay there? You look a little roughed up mate…”");
            }

            Console.ReadLine();
            Console.WriteLine("Bence showing up behind the two officers gives a WHAM!");
            Console.WriteLine("On the right-aligned officer’s head knocking him straight to the ground with the force of his pistol.");
            Console.WriteLine("“What the--” chanted by the left officer as Kaie, with the slide of his pistol slashes the remaining officer, knocking them clean out.");
            Console.ReadLine();

            Console.WriteLine("“That’s sorted.” Bence says, looking down at the unconscious officers on the ground.");
            Console.ReadLine();
            Console.WriteLine("“Officer, this is Cruz, what’s the current situation? Over.” grunted from a voice coming from the right officer’s walkie-talkie.");
            Console.ReadLine();

            Console.WriteLine("“Patryk-fucking Cruz. I swear that guy that--” Daniel mutters, limping forward.");
            Console.ReadLine();
            Console.WriteLine("“That’s a name that means we should leave now.” Bence replies, pushing Daniel towards the van with other two by his side.");
            Console.ReadLine();
            Console.WriteLine("“You know how to drive?” Bence utters to Isaac, as he helps Daniel into the back of the van.");
            Console.ReadLine();
            Console.WriteLine("“Yeah, wh--“");
            Console.WriteLine("Bence throws a pair of keys to Isaac, on him catching them, leaves his face blank as Bence and Kaie go in, shutting the Van’s back doors.");

            Console.ReadLine();
            Console.WriteLine("“Ok... Ok..” “We’re off.” Isaac mutters twisting the key in the ignition and starting the engine.");
            Console.WriteLine("He drives up the ramp coming out just to join a long line of lighted up cars.");
            Console.WriteLine("The good ol’ British traffic.");
            Console.WriteLine("Larsham‘s sky has darkened to a blackish blue with gusty winds and towering buildings on each side met with millions of water bullets firing down at the ground steaming up the van’s windows.");

            Console.ReadLine();
            Console.WriteLine("In the road ahead were barricaded by a long yellow parking barrier, with cars being stopped by the drenched officers.");
            Console.WriteLine("There was an army of police vans, motorcycles on opposite ends, officers in big coats patrolling with flashlights, talking to passing bystanders, marching with dogs at the barrier.");
            Console.WriteLine("All the officers are hovering around on the soaked and rain hammered road and pavements, the whole night was lit up by the bright blue flashing lights flickering on and off by their presence.");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("“They put a checkpoint ahead,” Kaie says reaching over to the windshield.");
            Console.ReadLine();
            Console.WriteLine("“What do we do?”");
            Console.ReadLine();
            Console.WriteLine("“Just stay cool.” Kaie addressed him reaching back to sit at the back of the van.");
            Console.ReadLine();
            Console.WriteLine("Issac twisting his body over his seat to the back “We’re getting closer. What should I say?!” As outside the windshield, car after car pass through the checkpoint.");
            Console.ReadLine();
            Console.WriteLine("“Say... Make something up...” He replies with a tone of defeat.");

            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("The next car drove off, passing through the raised parking wedge, leaving Isaac the next one up.");
            Console.WriteLine("He drives upfront to the parking barrier which is closing off the rest of the road.");
            Console.WriteLine("An officer at the centre gives a stop signal in front of the van and approaches the driver’s seat, knocking on the window.");
            Console.WriteLine("With Isaac winding it down, the officer brings some of the outside cold in, covering the van with a chilly haze.");
            Console.ReadLine();
            Console.WriteLine("“We have extremely dangerous criminals trying to escape from the local area. I’m going to need to take a quick look inside your van.“");
            Console.WriteLine("The officer exclaims, peeping inside and flashing Isaac with his torchlight.");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("“I have orders to escort this van full of illegal substances to HQ for... analysis.”");
            Console.ReadLine();
            Console.WriteLine("“From who’s authority?” The officer replied with his forehead and eyebrows raised.");


            Console.ReadLine();
            Console.WriteLine("1.“Direct orders from the Chief.”");
            Console.WriteLine("2.“The Innami, top secret.”");
            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2")
            {
                Console.WriteLine("Sorry, you must enter '1' or '2'.");
                Console.WriteLine("1.“Direct orders from the Chief.”");
                Console.WriteLine("2.“The Innami, top secret.”");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("“Is that so? I’m going to have to call it in.”");
                Console.WriteLine("The officer places his hand on his walkie-talkie on his shoulder. “Chief come in.”");
               
            }

            else if (finalChoice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("“Is that so? I’ve been doing this 20 years and I haven’t even met the head of the Innami.");
                Console.WriteLine("I’m going to have to call it in.”");
                Console.WriteLine("“Chief come in.”");
           
            }

            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("“DROP YOUR WEAPONS!” “DROP THEM NOW!” “PUT YOUR HANDS UP!”");
            Console.WriteLine("And similar sentences are screamed by the blacked up SWAT team circling around the van, with this weapons all aimed directly at the smaller three.");
            Console.WriteLine("With the three’s faces have shrunken with their weapons up.");
            Console.ReadLine();
            Console.WriteLine("“Fuck… We had it.” Kaie utters.");
            Console.WriteLine("One by one, they are dragged outside and cuffed up tightly with Kaie being the first then Daniel. “Get the HELL off me!”");
            Console.WriteLine("Bence attempting another drawl of vape to his mouth, a swat member smashing the vape stick out of his hand “I had some left, for fuck sake.”");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("“Hands up, out of the van, and do it slowly.” The officer has his hands wrapped tightly on his pistol aimed at directly at Isaac.");
            Console.WriteLine("“Shit.” He mutters under his breath.");
            Console.WriteLine("The officer with his other hand proceeds to open the door letting Isaac with his arms raised out, cuffing him against the van’s door.");
            Console.WriteLine("“I have nothing to do—“ and pushing him over to join the other cuffed three.");

            Console.ReadLine();

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("“Well, well, well I love seeing some familiar faces…” A straight shaped figure with broad shoulders strides forward to them.");
            Console.ReadLine();
            Console.WriteLine("“Line them up.”  The officers take each of the group and places them together into a line on their knees.");
            Console.WriteLine("The figure has a wrinkled stressed face with a mix of black and grey hair and stubble on his chin.");
            Console.WriteLine("Dressed in a smart black blazer accented with a black tie with many different colours of badges over it.");

            Console.ReadLine();
            Console.WriteLine("“But you got a new one haven’t you?”");
            Console.ReadLine();
            Console.WriteLine("“I must thank your friend for reacquainting us, we’ve been following you guys all day.“");
            Console.ReadLine();
            Console.WriteLine("“Let him go Patryk, he has nothing to do with us—“Kaie replies.");
            Console.WriteLine("“Shut up.”");
            Console.ReadLine();
            Console.WriteLine("Soo… Isaac is it?” “What you’ve done or at least tried to obtain are some very bad things, prohibited things that we don’t allow here.”");
            Console.ReadLine();
            Console.WriteLine("“I’ll let you walk, scotch free, like nothing ever happened.”");
            Console.WriteLine("“Let’s say... you’ve repented for your crimes.”");


            Console.ReadLine();
            Console.WriteLine("“Why don’t you shoot Dan over here, he’s a bit of a pain the ass, I know I’ve been chasing these drug dealers for half a century at least, but hell I’ll let you choose.”");
            Console.ReadLine();
            Console.WriteLine("“And choose quickly.“ Patryk firmly states.");
            Console.ReadLine();

            Console.WriteLine("He takes out his gun and looks at it “You know how to use this right?” He cocks the gun and takes Isaac’s hands and tightly grips them on the pistol.");
            Console.ReadLine();
            Console.WriteLine("“Bullet rightttt…” He throws in as he pokes his finger directly on Daniel’s forehead. “Here.”");
            Console.ReadLine();
            Console.WriteLine("“No...”");
            Console.ReadLine();
            Console.WriteLine("“I won’t.”");
            Console.ReadLine();
            Console.WriteLine("“What do a couple of drug dealers mean to you?”");
            Console.ReadLine();
            Console.WriteLine("“You’re the evil one and those Innami scum”");
            Console.ReadLine();
            Console.WriteLine("“You don’t have much choice here.”");
            Console.ReadLine();
            Console.WriteLine("“You see this?” He waves his finger around to the kneeled tied down group. “I don’t think you have much choice in the matter.”");
            Console.ReadLine();
            Console.WriteLine("“I’m waiting.”");
            Console.ReadLine();
            Console.WriteLine("Each person of the kneeled faces’ begin to tighten up including Isaac’s.");

            Console.ReadLine();
            Console.WriteLine("“You can’t kill what we stand for.” Bence blurts.");
            Console.ReadLine();
            Console.WriteLine("“Oh, I plan too, make your decision.”");



            Console.ReadLine();
            Console.WriteLine("1.(Shoot Kaie)");
            Console.WriteLine("2.(Shoot Bence)");
            Console.WriteLine("3.(Shoot Patryk)");
            Console.WriteLine("4.(Shoot Daniel)");
            
            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2" && finalChoice != "3" && finalChoice != "4")
            {
                Console.WriteLine("Sorry, you must enter '1', '2', '3' or '4'.");
                Console.WriteLine("1.(Shoot Kaie)");
                Console.WriteLine("2.(Shoot Bence)");
                Console.WriteLine("3.(Shoot Patryk)");
                Console.WriteLine("4.(Shoot Daniel)");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1") //Kaie
            {
                Console.WriteLine();
                Console.WriteLine("*Click* sounds blurt out of the gun. Isaac lets out a gasp of air as he drops the gun to the floor.");
                Console.WriteLine();
                Console.WriteLine("“Hm…”");
                Console.WriteLine("“Wow, I would have chosen the less smart one.” He says as he grabs his gun back from the floor.");
                Console.WriteLine("“But I’m sure you know I can’t have you parading on the streets.”");
                Console.WriteLine("“Put them in the van” The officers drag them to the back of a SWAT Van.");
                Console.WriteLine("“As much as I want to myself, I’ll let the Innami deal with you”");
            }

            else if (finalChoice == "2") //Bence
            {
                Console.WriteLine();
                Console.WriteLine("*Click* sounds blurt out of the gun. Isaac lets out a gasp of air as he drops the gun to the floor.");
                Console.WriteLine();
                Console.WriteLine("“Good Idea, getting rid of the lower rank, street dealer.” He says as he grabs his gun back from the floor.");
                Console.WriteLine("“Much more than that, pig!” Bence fires at him.");
                Console.WriteLine("“But I’m sure you know I can’t have you parading on the streets.”");
                Console.WriteLine("“Put them in the van” The officers drag them to the back of a SWAT Van.");
                Console.WriteLine("“As much as I want to myself, I’ll let the Innami deal with you”");

            }

            else if (finalChoice == "3") //Patryk
            {
                Console.WriteLine();
                Console.WriteLine("*Click* sounds blurt out of the gun. Isaac lets out a gasp of air as he drops the gun to the floor.");
                Console.WriteLine();
                Console.WriteLine("“Hm... I admire your new found loyalty, you’re in way over your head.“ He says as he grabs his gun back from the floor.");
                Console.WriteLine("“But I’m sure you know I can’t have you parading on the streets.”");
                Console.WriteLine("“Put them in the van” The officers drag them to the back of a SWAT Van.");
                Console.WriteLine("“As much as I want to, I’ll let the Innami deal with you”");
            }

            else if (finalChoice == "4") //Daniel
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*Click* sounds blurt out of the gun. Isaac lets out a gasp of air as he drops the gun to the floor.");
                Console.WriteLine();
                Console.WriteLine("“Great Choice buddy.” He taps on his shoulder as he grabs his gun back from the floor.");
                Console.WriteLine("“I would have chosen the exact same person.“ He says as he pats Daniel’s shoulder.");
                Console.WriteLine("“As much I would like to have Danny boy’s brains splattered on this fine pavement, I’ll have to let the Innami deal with you”");
                Console.WriteLine("“I’m sure you know I can’t have you parading on the streets.”");
                Console.WriteLine("“Put them in the van” The officers drag them to the back of a SWAT Van.");

            }


            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("“We been in this van too long now, I’m not dying here.”");
            Console.WriteLine("“I’m not letting him kill the only piece of culture we have left” Daniel exclaims to the handcuffed group.");
            Console.ReadLine();
            Console.WriteLine("“I’m sorry—”");
            Console.ReadLine();
            Console.WriteLine("“You did what you have to do in the given moment Isaac.”");
            Console.WriteLine("“Let’s worry about getting out of this situation”");

            Console.ReadLine();
            Console.WriteLine("“Any Ideas getting out of this mess?” Kaie throws back at him.");
            Console.ReadLine();
            Console.WriteLine("“We should do something about the driver over there” Bence utters.");
            Console.ReadLine();
            Console.WriteLine("“You still got some Pozza left?”");
            Console.WriteLine("“Always.” Bence instantly replies.");
            Console.ReadLine();
            Console.WriteLine("“How about giving our friends here a taste?” Daniel exclaims around the group.");
            Console.ReadLine();
            Console.WriteLine("Bence clenches a bag of Pozza from his pocket begins to pour a big amount of the powder the powder on his open palm.");

            Console.ReadLine();
            Console.WriteLine("“Make some noise.” Kaie utters. On which the group stamp their feet on the floor repeatedly up and down");
            Console.ReadLine();
            Console.WriteLine("“Calm it down in there—”");
            Console.ReadLine();
            Console.WriteLine("“Bence NOW!”");
            Console.ReadLine();
            Console.WriteLine("Bence launches the clenched powder through the mini-door into the driver’s face…");
            Console.ReadLine();
            Console.WriteLine("“AHHH!” “I CAN’T FUCKING SEE!”");
            Console.WriteLine("The driver stomps his on the van’s break, crashing the van’s rear into the car behind.");
            Console.WriteLine("On which the driver begins to drive forward and break, screeching onto the road rolling the van over.");
            Console.WriteLine("With the car behind swivelling meeting the same fate.");

            Console.ReadLine();
            Console.WriteLine("“Oh shi—we’re!");
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Isaac’s blurry vision wakes up lying on his back in a flipped over and glass filled van smeared in an whiteish grey smoke.");
            Console.ReadLine();
            Console.WriteLine("“AHHHH!”");
            Console.WriteLine("“Shit.” Isaac’s body is drenched and covered all over with Blood and deep cuts.");
            Console.ReadLine();
            Console.WriteLine("“Need to get out… get out.” He sees the damaged rear doors and crawls over to kick on the door repeatedly.");
            Console.ReadLine();
            Console.WriteLine("“Come on…” He stamps his feet on the doors exerting all the strength he has left “COME ON!”");
            Console.ReadLine();
            Console.WriteLine("With the last forceful kick smashing open the door with him crawling out onto the road, and letting out some moans of agony and deep breaths.");
            Console.WriteLine("The air is now polluted with a thick muddy black sludge of smoke mixed with a blazing violet orange fire from both the van and the car.");
            Console.WriteLine("It producing a overwhelming eyewatering musty oaky smell.");
            Console.WriteLine("He pulls himself up now with a limp stunting his height.");

            Console.ReadLine();
            Console.WriteLine("“Shit, the others.” He limps over back in front of the doors with great weight.");
            Console.WriteLine("To see a beaten up Kaie dragging out equally injured Daniel “Daniel!”");
            Console.WriteLine("“Kaie!”");
            Console.ReadLine();
            Console.WriteLine("“I told you I wasn’t dying here.” He utters with a deep repeated cough.");
            Console.ReadLine();
            Console.WriteLine("“Where’s—“");
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("“You wouldn’t just sit there and accept your fates.”"); 
            Console.WriteLine("Patryk says limping heavy-footed to the group from the actively burning car with still a strong but injured stance.");
            Console.WriteLine("Face full of cuts and parts of his clothes and badges have been burned.");
            Console.WriteLine("With a pistol firmed in his hand aimed at Isaac.");

            Console.ReadLine();
            Console.WriteLine("“Someone kill this guy already.” Kaie mutters rolling on the floor.");
            Console.ReadLine();
            Console.WriteLine("“I was going to be kind and let those Innami fucks deal with you.");
            Console.WriteLine("But you have been become a real PAIN IN MY BACKSIDE and I will end this myself!”");
            Console.WriteLine("“And I assure you this gun has bullets in—AHHH!” Bence exerts a burst of strength, tightly wrapping  the chain of the handcuffs onto his neck.");
            Console.ReadLine();
            Console.WriteLine("“ISAAC!” I can’t hold him forever shoot him!” Kaie proceeding to slide over a pistol to Isaac.");
            Console.ReadLine();
            Console.WriteLine("“End it”");

        }


        static void FinalFightMethod()
        {
           
            String finalChoice;
           

            Console.ReadLine();
            Console.WriteLine("1.(Shoot Patryk)");

            finalChoice = Console.ReadLine();

            while (finalChoice != "1" && finalChoice != "2" && finalChoice != "Pizza Night" && finalChoice != "pizza night")
            {
                Console.WriteLine("Sorry, you must enter '1' or '2'");
                Console.WriteLine("1.(Shoot Patryk)");
                Console.WriteLine("2.(Do Nothing)");
                finalChoice = Console.ReadLine();
            }

            if (finalChoice == "1")
            {
               
                GoodEndingMethod();
            }

            else if (finalChoice == "2")
            {
                AlternativeEndingMethod();
            }


            else if (finalChoice == "Pizza Night" || finalChoice == "pizza night")
            {
                SecretEnding();
            }

        }

        static void RestartStoryMethod()
        {
            StoryMethod();

        }

        static void GoodEndingMethod()
        {
            Console.WriteLine();
            Console.WriteLine("The bullet speed straight into the centre of Patryk’s forehead which brings a moment of final defeat plastered on his face and blood spraying out of the hole.");
            Console.WriteLine("Which brings his body crashing to the ground. Bence seeing this drops to the floor onto his back.");
            Console.ReadLine();
            Console.WriteLine("“Not a bad shot for a first timer.” Kaie says with a congratulatory tone.");
            Console.ReadLine();
            Console.WriteLine("“I never liked that prick.” Daniel mutters rolling to his side with relief.");
            Console.ReadLine();
            Console.WriteLine("“Ay Bence!”");
            Console.ReadLine();
            Console.WriteLine("“Yeah?!”");
            Console.ReadLine();
            Console.WriteLine("“Can I have that pizza now?");
            Console.ReadLine();
            Console.WriteLine("“All the pizza in the world, my friend.”");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("THE END. :)");
            Console.WriteLine("Thanks for playing! Hope you enjoyed, and make sure to give me feedback! :)");
            Console.ReadLine();
            return;
        }







        static void AlternativeEndingMethod()
        {
            
            Console.WriteLine();
            Console.WriteLine("Patryk fires an fiery back headbutt to Bence’s face breaking free and swishes around to fire an shot into Bence’s face");
            Console.WriteLine("“Oh shit.”");
            Console.WriteLine("Patryk with a sudden burst of energy strides forward once more.");
            Console.WriteLine("Putting multiple bullets into Kaie and Daniel and finally walks towards Isaac, shooting into his hand holding the gun.");
            Console.ReadLine();
            Console.WriteLine("He whips his pistol on Isaac’s head knocking him to the floor.");
            Console.ReadLine();
            Console.WriteLine("“You should’ve have stayed in the van.”");
            Console.ReadLine();
            Console.WriteLine("And fires his final bullet into Isaac.");

            Console.ReadLine();
            Console.WriteLine("With the final resistance’s demise, Innami domination is complete and underground pizzerias are now completely eradicated, hope for future pizza consumption comes to a complete end.");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("THE END.");
            Console.WriteLine("Thanks for playing! Hope you enjoyed, and make sure to give me feedback! :)");
            Console.ReadLine();
            return;
            
        }

        static void SecretEnding()
        {
            Console.WriteLine();
            Console.WriteLine("A shot from Patryk's gun fires straight into Isaac prompting him to awaken on a nice soft bed.");
            Console.ReadLine();
            Console.WriteLine("Turns out it was just a normal Friday afternoon.");
            Console.ReadLine();
            Console.WriteLine("He reaches over to his bedside to look over a text from a friend asking to go out for some drinks.");

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("THE END. :) :)");
            Console.WriteLine("You found the secret ending!");
            Console.WriteLine("Thanks for playing! Hope you enjoyed, and make sure to give me feedback! :)");
            Console.ReadLine();
            return;
        }


        
        static void Main(string[] args)
        {

            StoryMethod();
            FinalFightMethod();


        }
    }
}
