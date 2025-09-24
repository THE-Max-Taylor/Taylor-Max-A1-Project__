
Console.WriteLine("The wind brushes against your nose, your eyes slowly fluttering open. You find yourself in a meadow, grassy hills rolling out in every direction. You try to stand, but quickly");
Console.WriteLine("collapse. Looking down it occurs to you that you now have four legs.");
Console.WriteLine("Congratulations. You are a deer. You freak. Do you accept your reality?");
Console.WriteLine("...");
Console.WriteLine("Yes or No?");
string reply = Console.ReadLine();

if (reply == "Yes")
{
    Console.WriteLine("I'm glad we're on the same page.");
    Console.WriteLine("I'm going to level with you. This is sort of weird. I think the only thing you can really do at this point is move forward.");
    Console.WriteLine("More specifically I mean to Mrs. Hedgehog's house. She'll know what to do. Would you like to use your Deer Legs to head on over?");
    Console.WriteLine("...");
    Console.WriteLine("Yes or No?");

    string secondReply = Console.ReadLine();


    if (secondReply == "No")

    {
        Console.WriteLine("Oh you're gonna be one of those people. Those people who never got enough attention from mommy so now they've gotta parade around like a royally annointed contrarian.");
        Console.WriteLine("Alright, jackass. If we're not going to Mrs. Hedgehog's house, where are we going? The freeway? Or the Hunter's Lodge?");
        Console.WriteLine("...");
        Console.WriteLine("Freeway or Hunter's Lodge?");

        string thirdReply = Console.ReadLine();

        if (thirdReply == "Freeway")
        {
            Console.WriteLine("Goody.");
            Console.WriteLine("Okay, after stumbling through the forest on your set of awkward deer-shaped legs, you reach the freeway. Cars zip and zag every which way, wordlessly threatening to rip");
            Console.WriteLine("you in half with the awesome powers of rubber and steel.");
            Console.WriteLine("I think you should be able to make it if you time this juuust right...");
            Console.WriteLine("...");
            Console.WriteLine("Go or Wait?");

            string timingReply = Console.ReadLine();

            if (timingReply == "Go")
            {
                Console.WriteLine("Oh damn. Yeah. No. No that timing was unwise. That was inopportune");
                Console.WriteLine("In your haste, you don't see the truck careening towards you at 70 mph. You're just about everywhere.");
                Console.WriteLine("I need a shower... Game Over, in case that wasn't obvious... Better luck next time...");
            }

            else if (timingReply == "Wait")
            {
                //Set HP for Car Scene. The player's health will decrease more if they're hit by a heavier vehicle. If they make it to the end with their HP above zero then they are a winner winner chicken dinner.
                int Health = 100;

                Console.WriteLine("Good call, as you stand on the cusp of the road a truck hurtles by at 70mph. That would have proven a grizzly scene indeed.");
                Console.WriteLine("...");
                Console.WriteLine("Okay, the coast is clear. After waiting for the right opening, you venture forth into the middle of the street. Using your newly awakened deer senses, you realize");
                Console.WriteLine("two vehicles are headed your way. One is a 2022 Subaru Forester, the other a Kalmar T2 Terminal Tractor. There's nowhere to run. You have to leap in front of one.");
                Console.WriteLine("...");
                Console.WriteLine("Subaru or Kalmar?");

                string carReply = Console.ReadLine();

                if (carReply == "Subaru")
                {
                    Health -= 30;
                    Console.WriteLine($"Okay, badass. Your health is now {Health}. Oh, also you have health now by the way. Yeah, it became a mechanic when you walked into the freeway. Congrats.");
                }

                else if (carReply == "Kalmar")
                {
                    Health -= 60;
                    Console.WriteLine("Wow, what a play. No, I respect the decision. Having a deathwish is kind of cool in a depressing sort of way. Nihilism does really great at parties.");
                    Console.WriteLine($"Your health is now {Health}. Oh, also you have health now by the way. Yeah, it became a mechanic when you walked into the freeway. Congrats.");
                }

                else
                {

                    Health -= 90;
                    Console.WriteLine("Is typing a coherent response simply beyond you? Both cars hit you as you sputter and stutter like a fool.");
                    Console.WriteLine($"Your health is now {Health}. Yeah, you have health now. I mean, at this point you may as well not have any. You started with 100.");
                    Console.WriteLine("I don't even know what to say, man. Like, I coded the next scenario to require the player to have at least 30 HP. Wait, did I? One sec.");
                    Console.WriteLine("...");
                    Console.WriteLine("... Yeah, yeah I did. I'm sorry guy, but you aren't winning this one. Just restart the game, save us both some time. Maybe learn to type next time.");
                }


                Console.WriteLine("You pick yourself up off the road and stagger forwards, undeterred. Suddenly, two more vehicles veer your way! Quickly, will you leap in front of:");
                Console.WriteLine("A 2006 Honda Civic?");
                Console.WriteLine("Or...");
                Console.WriteLine("A '26 Ram 2500?");
                Console.WriteLine("...");
                Console.WriteLine("Civic or Ram?");

                string carSecondReply = Console.ReadLine();

                if (carSecondReply == "Civic")
                {
                    Health -= 30;
                    Console.WriteLine("Hell yeah. You're a natural. You're like a professional. Pardon the capitalist in me, but you should really consider doing this for a living.");
                    Console.WriteLine($"Your health is now {Health}. I wish you could be as proud of you as I am. I love you.");
                    Console.WriteLine("Positive reinforcment is the best kind of reward. Every game should reinforce the player this positively. Metal Gear Solid wishes it was Deer Quest.");
                    Console.WriteLine("That's the name of this game by the way. Deer Quest. I just decided that right now. Do you like it.");
                    Console.WriteLine("...");
                    Console.WriteLine("Yes or No?");

                    string doYouLikeIt = Console.ReadLine();

                    if (doYouLikeIt == "Yes")
                    {
                        Console.WriteLine("This is so cool. I don't want to, like, be too much right now, but I just feel like we have this spark, y'know? Like you get me?");
                        Console.WriteLine("Yes or No-");
                        Console.WriteLine("No, no. You don't have to respond. I know you feel the same. In fact, it's better that you don't speak. Let's just appreciate this moment in mutual silence.");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("Okay that's probably long enough. Anyways.");
                    }
                    else { Console.WriteLine("That's okay. You didn't understand the question. We all move at different speeds. And I think that's beautiful. Anyways."); }
                }

                else if (carSecondReply == "Ram")
                {
                    Health -= 60;
                    Console.WriteLine("I bet you're some kind of neoliberalist, aren't you. Yeah you are. Choices speak louder than words.");
                    Console.WriteLine($"Your health is now {Health}. It could be higher, that's all I'll say. It could be a lot higher right now. I'll just say that.");
                }

                else { Console.WriteLine("Girlie really can't type words written out right in front of her. Who is this diva."); }


                if (Health > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You seem to be alive, and- what's this?! Something is shifting, just beneath your deer-skin... Oh, god (read jubilantly)!");
                    Console.WriteLine("You're emerging from this flesh like a cocoon, your human form tearing past fur and deer-bone to taste fresh air once more...");
                    Console.WriteLine("The bravery you displayed by crossing that freeway like a bonefide SuperMoron must have satisfied whatever higher power dropped you in this mess.");
                    Console.WriteLine("I won't question it, I'm just an RPG. Congrats, girl! You're free from what bound you, AND you got to taste deer-blood!!");
                    Console.WriteLine("REBIRTH - ENDING COMPLETE");



                }

                else { Console.WriteLine("You have run out of health. Thus ends this sordid tale. Better luck next time, sweet prince."); }



            }
            else { Console.WriteLine("Oh my god, your options were 'Go' and 'Wait', how did you screw that up??"); }

        }
        else if (thirdReply == "Hunter's Lodge")
        {
            Console.WriteLine("Okay, so there was no good option there I'll admit. I get you probably felt written into a corner. I get the freeway might've looked worse from a distance. I get that.");
            Console.WriteLine("But this was the worst option available. I mean, like, hunters kill deers. You get that, right? That hunters kill deers? Cars don't make a day out of killing you.");
            Console.WriteLine("But you know who does? Hunters. Like obviously. The hunters are gonna try to kill you. Like obviously. I'm sorry, I'm becoming less sympathetic to this decision as time wears on.");
            Console.WriteLine("Like, cars are BIG. You can straight up walk around a car. You know what you can't walk around? A bullet.");
            Console.WriteLine("Did you know the fastest car in the world can travel up to 347 miles per hour? That's neat, huh?");
            Console.WriteLine("You wanna know how fast the slowest bullet in the world can travel? 700 miles per hour. No, No, No, Genuinely, Genuinely What Is Wrong With You.");
            Console.WriteLine("This is a text based game. This is a text based video game. You could've sat on that choice for hours. Days. Years. There is no excuse.");
            Console.WriteLine("The pressure was nonexistent and yet you found a way to crack under it. Jesus Christ.");
            Console.WriteLine("..........");
            Console.WriteLine("I'm calm now, I'm calm. It's cool. You make your way to the hunter's lodge. Surprisingly, there are hunters there. A dozen rifle barrels flash towards your deer-head in unison.");
            Console.WriteLine("The leader, standing at around 7 feet tall, approaches you. His pecs bulge. One pec is named Tom, the other Sue. Just thought I'd fill you in on the pectoral situation.");
            Console.WriteLine("'Well', he says, his voice devoid of intrigue, 'this does intrigue me. A fly wandering straight into a spider's nest.'");
            Console.WriteLine("He meant to say web, but leave him be. He needs this. It seems as though a decision must be made, do you want to fight or flee?");
            Console.WriteLine("...");
            Console.WriteLine("Fight or Flee?");

            string fightOrFlee = Console.ReadLine();

            if (fightOrFlee == "Flee")
            {
                Console.WriteLine("You speed through the treeline as fast as you can, yet you find yourself disoriented within your corporeal form. ");
                Console.WriteLine("You trip on a pinecone (embarassing) and hit the ground with a hideous 'snap'.");
                Console.WriteLine("You've broken your neck. The hunters are dissapointed. I'm dissapointed. Quite frankly, you're dissapointed.");
            }

            else if (fightOrFlee == "Fight")
            {
                Console.WriteLine("You throw a hoof-shaped punch forwards, the leader grabbing it without flinching (badass). You feel your bones shatter within his iron grasp. He looks at you, unimpressed.");
                Console.WriteLine("'I'm impressed. Having a deathwish is cool in a depressing kind of way' he says, smirking. 'How would you rate your level of fear, on a scale of 1-10?'");
                Console.WriteLine("...");
                Console.WriteLine("How would you rank your fear? Preferably within the guidelines of 1-10?");

                //The hunters will assume the player is bluffing. To overcome their skepticism the player must show no fear and input the lowest number possible. You've gotta be a real badass to type "1".

                int rankFear = int.Parse(Console.ReadLine());

                int trueFear = rankFear + 4;

                Console.WriteLine($"'Heh. Liar. People always rank lower than they really feel to save face. I can see it in your eyes. You may think you're a {rankFear}, but really? You're a {trueFear}.'");
                if (trueFear < 6)
                {
                    Console.WriteLine("'And yet, that number...' he says, releasing your hoof with an approving nod, 'It is mighty indeed'.");
                    Console.WriteLine("With one swift motion, the hunters pull at their throats in unison... No, not throats... Masks.");
                    Console.WriteLine("They're deers. All of them are deers.");
                    Console.WriteLine("'Come on son', the head honcho grunts sagely, 'we have much to discuss'.");
                    Console.WriteLine("THROUGH THE LOOKING GLASS - ENDING COMPLETE");


                }

                else if (trueFear >= 6)
                {
                    Console.WriteLine("'It's a shame. You had such potential, boy. Too bad I'll have to use the Hunter's Strike on you now'.");
                    Console.WriteLine("Yet you never find out what exactly the Hunter's Strike is, as it kills you at a speed faster than light itself. Rest well, cowardly prince.");
                }

                else { Console.WriteLine("Would it really have been too much effort to just type out a number??"); }

            }
            else { Console.WriteLine("Due to your inability to type coherently, the hunters open fire out of spite. You have died. But your legacy? It has died too, actually."); }
        }

        else { Console.WriteLine("If you're going to waste my time at least waste it intelligently. Sorry, I'll slow down. What I meant to say was: Learn how to type."); }

    }
    else if (secondReply == "Yes")
    {
        Console.WriteLine("I knew it. You're a follower. A rule abider. A Hot Topic shopper.");
        Console.WriteLine("Favorite director? Kurosawa. Favorite game? Ocarina of Time. Favorite book? 'Aw man there are just so many'. That's a cool shirt, where'd you get it? Thrifting? No. Way.");
        Console.WriteLine("No, like, it's fine. You're just basic. That's okay. Statistically most people have to be. No. Don't tell me. Your favorite indie game is Celeste. I knew it.");
        Console.WriteLine("Okay, sorry, right. Mrs. Hedgehog. Let's be off.");
        Console.WriteLine();
        Console.WriteLine("After venturing through the thickets and brambles, you find yourself on a scenic prarie. You spot a cottage, peering over the horizon. Easy pickin's- wait What's That?");
        Console.WriteLine("... Yeah I'm not quite sure what we're looking at. It looks like a middle ground between a wart and the hideous afterbirth of some failed cross-species- Did it just move??");
        Console.WriteLine("Yeah. Yeah no. No. I wanna veto this. Please don't satiate your curiosity. Please.");
        Console.WriteLine("...");
        Console.WriteLine("Grab or Leave?");

        //Determines if the player keeps the hideous child in their inventory by adding +1 child.
        int babyHog = 0;
        string pickOrLeave = Console.ReadLine();
        if (pickOrLeave == "Grab")
        {
            babyHog++;
            Console.WriteLine("Christ.");
        }
        else if (pickOrLeave == "Leave")
        {
            Console.WriteLine("You're all right. I'm sorry I said you shop at Hot Topic. Statement retracted.");
        }

        else { Console.WriteLine("I don't know what that means so we're just moving on. We're just gonna go. We're going now."); }

        Console.WriteLine("Okay, no more detours. You arrive at Mrs. Hedgehog's front step, greeted by an odd noise. Is she... Crying in there? Probably not. You rap upon the door with your deer hooves.");
        Console.WriteLine("The hinges creak gently as it swings open. You are greeted by a kindly old face staring up at yours, eyes wet. Her eyes are probably wet from crying. Just reading the room.");
        Console.WriteLine("'H-hello dearie' she whispers, sniffling, 'I see you're a deer. This is a tragedy indeed. A pretty thing like you deserves to be in your own skin, not confined to those hooves.'");
        Console.WriteLine("'I'd love to cure you with my DEER BLAST! but... I-I-' she begins to cry. Mucus. Tears. It's an uncomfortable situation for both of us. You pat her on the shoulder non-commitally.");
        Console.WriteLine("'M-m-my son... I lost him, out in the fields... My bouncing baby boy... My little Wartlaby... I can't WORK under such strife!'");
        Console.WriteLine();
        Console.WriteLine("Oh my god. That. Thing. That thing. It's her son. Her son was that Thing. Okay. Um. Do you still have it? Him? I'll check for you.");

        if (babyHog > 0)

        {
            Console.WriteLine();
            Console.WriteLine("Okay badass i found it. Him.");
            Console.WriteLine("'WARTLABY!! OH MY DEAR SWEET WARTLABY. Thank you noble deer, oh may the spirits bless you'. She cradles the. Child. In her arms as it emits a cooing-type noise.");
            Console.WriteLine("'My heart is whole once more. I shall return you to your original corporeal form, should you wish'.");
            Console.WriteLine();
            Console.WriteLine("Is this really what you want? There will be no second chances.");
            Console.WriteLine("...");
            Console.WriteLine("Yes or No?");

            string finalChoice = Console.ReadLine();

            if (finalChoice == "Yes")
            {

                Console.WriteLine("The kindly old hedgehog utters a guttural cry, 'DEER BLAAAST!!' and you are enveloped in a brilliant white light. As you vision returns, you stare down at your hands.");
                Console.WriteLine("That's right. Not hooves. HANDS. The spell was a brilliant success. Your nose. Your feet. Your FINGERS. All as it should be. Balance. Is. Restored.");
                Console.WriteLine("'As a special treat for being sooo helpful dearie, I threw in a MAGIC BONUS!' The kind old hedgehog says, smiling jovially.");
                Console.WriteLine("After a moment of confusion it finally dawns on you.");
                Console.WriteLine("'You are a girl now.'");
                Console.WriteLine("TRUE ROUTE - ENDING COMPLETE");

            }
            else if (finalChoice == "No")
            {
                Console.WriteLine("I gotta say. That's bold. So bold it's almost questionable. So questionable it's almost stupid. So stupid I find you irritating.");
                Console.WriteLine("Everything was perfect! You did everything right! You were almost there! Did you know she was gonna make you a girl? Yeah! In the true ending you turn into a girl!");
                Console.WriteLine("But you just HAD to veer off course. Things were going TOO well for you. Did my Hot Topic comment seriously upset you this badly?? Is this you acting out??");
                Console.WriteLine("Y'know, sometimes it's TOTALLY FINE to follow the path of least resistance. Sometimes you just need to LET YOURSELF BE HAPPY. You can buy overpriced alt clothing, I don't actually care!!");
                Console.WriteLine();
                Console.WriteLine("STUPID ENDING (for being stupid) - UNLOCKED");
                Console.WriteLine();
                Console.WriteLine("Nah. Nah screw this. We're going back. You're saying yes. Replay the game. Do it.");
            }
            else
            {
                Console.WriteLine("Noone can really make out what you said. It kind of sounded like a 'No'...? So... Mrs. Hedgehog eventually just kinda... Shuts the door. Yeah. Sorry. That's rough.");
                Console.WriteLine("MISCOMMUNICATION(?) - ENDING UNLOCKED");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Wait, did you not pick it up?? Was it because I told you not to???? Why would you listen to my opinion?!! You just met me!!! We aren't, like, close!");
            Console.WriteLine("Mrs. Hedgehog's poor little heart can't take another moment of being separated from her bundle of joy, and she collapses onto the ground...");
            Console.WriteLine("Okay, checked her pulse. Yeah. She's dead. Great job. Greeeat job.");
            Console.WriteLine("Have fun as a deer I guess.");
            Console.WriteLine("Bye.");
        }

    }
    else { Console.WriteLine("You're already losing the ability to type? I'm not even gonna humor this adventure. Bye."); }



}

else if (reply == "No")
{
    Console.WriteLine("No? You're not a deer? Look at you. You're delusional. In your arrogance, you don't think to look up at the truck careening towards you at 70mph.");
    Console.WriteLine("You have died, devoid of your identity, a false skin smothering your own. Better luck next time.");
}

else
{
    Console.WriteLine("Sorry, I don't speak gibberish. Maybe type what I've written? Baby graduated kindergarten, right?");
}
