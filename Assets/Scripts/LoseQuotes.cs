using System.Collections.Generic;
using UnityEngine;

public class Quoutes {
    public static string GetRandomQuote() {
        var i = Random.Range(0, quotes.Count - 1);
        return quotes[i];
    }

    public static List<string> quotes = new List<string>{
    "Losing a game is not a big deal, except you’ve got to make sure that you move on and get the next one.",
    "Sometimes by losing a battle you find a new way to win the war.",
    "You’re never a loser until you quit trying.",
    "Losing a game is heartbreaking. Losing your sense of excellence or worth is a tragedy.",
    "Losing doesn’t eat at me the way it used to. I just get ready for the next play, the next game, the next season.",
    "We didn’t lose the game; we just ran out of time.",
    "I’ve failed over and over and over again in my life and that is why I succeed.",
    "The will to win is important, but the will to prepare is vital.",
    "Adversity causes some men to break; others to break records.",
    "The minute you start talking about what you’re going to do if you lose, you have lost.",
    "Apparently, when you head a football, you lose brain cells, but it doesn’t bother me. I’m a horse. No one’s proved it yet has they?",
    "You’ve got to take the rough with the smooth. It’s like love and hate, war and peace, all that boll*cks.",
    "I can see the carrot at the end of the tunnel.",
    "I always used to put my right boot on first, and then obviously my right sock.",
    "I’m as happy as I can be – but I have been happier.",
    "It was like deja-vu all over again.",
    "Left alone with our own heads on, we can be pretty mental.",
    "It’s a no-win game for us. Although I suppose we can win by winning.",
    "He’s started anticipating what’s going to happen before it’s even happened.",
    "I was really surprised when the FA knocked on my doorbell.",
    "I’m in competition with myself and I’m losing.",
    "There is plenty of competition in a Glasser Quality School in that there is winning but no losing.",
    "Race, what is that? Race is a competition, somebody winning and somebody losing. Blood doesn’t run in races! Come on!",
    "I don’t like the idea of competition – maybe because I kept losing them when I was a kid. Maybe it’s better to be the one who loses?",
    "Sometimes by losing a battle you find a new way to win the war.",
    "Competition is the keen cutting edge of business, always shaving away at costs.",
    "I know what a really bad day is…and that’s not losing a competition.",
    "I’m afraid of losing my sense of trying to always be better. I love competing against myself.",
    "In life, winning and losing will both happen. What is never acceptable is quitting.",
    "How a person wins and loses is much more important than how much a person wins and loses.",
    "You have no choices about how you lose, but you do have a choice about how you come back and prepare to win again.",
    "It’s not whether you win or lose, it’s how you place the blame.",
    "Winning is great, sure, but if you are really going to do something in life, the secret is learning how to lose.",
    "The greatest test of courage on earth is to bear defeat without losing heart.",
    "I love the winning, I can take the losing, but most of all I love to play.",
    "The minute you start talking about what you’re going to do if you lose, you have lost.",
    "It’s not whether you get knocked down, it’s whether you get up.",
    "When you win, say nothing. When you lose, say less.",
    "Losing a game is not a big deal, except you’ve got to make sure that you move on and get the next one.",
    " You’re never a loser until you quit trying.",
    "Losing a game is heartbreaking. Losing your sense of excellence or worth is a tragedy.",
    "Losing doesn’t eat at me the way it used to. I just get ready for the next play, the next game, the next season.",
    "I’ve failed over and over and over again in my life and that is why I succeed.",
    "The will to win is important, but the will to prepare is vital.",
    "The minute you start talking about what you’re going to do if you lose, you have lost.",
    "You need to play with supreme confidence, or else you’ll lose again, and then losing becomes a habit.",
    "Besides pride, loyalty, discipline, heart, and mind, confidence is the key to all the locks.",
    "The pric of success is hard work, dedication to the job at hand.",
    "Losing is part of the game. If you never lose, you are never truly tested, and never forced to grow.",
    "Failure does not come from losing, but from not trying.",
    "Success is never final. Failure is never fatal. It’s courage that counts.",
    "You have no choices about how you lose, but you do have a choice about how you come back and prepare to win again.",
    "Bad things do happen; how you respond to them defines your character and the quality of your life. You can choose to sit in perpetual sadness, immobilized by the gravity of your loss or you can choose to rise from the pain.",
    "It’s not whether you get knocked down; it’s whether you get back up.",
    "Never give up, never give in, and when the upper hand is ours, may we have the ability to handle the win with the dignity with which we absorbed this loss.",
    "Do you know what my favorite part of the game is? The opportunity to play."
};
}
