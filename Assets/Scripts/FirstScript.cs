using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public string firstCase = "Scissors";
    public string secondCase = "Paper";
    //public Shape men;
    //public Shape dusmen;

    void Start()
    {

        print(RockPapaerScissors(Shape.Rock, Shape.Paper));

        //switch (men)
        //{
        //    case FirstEnum.Rock:
        //        switch (dusmen)
        //        {
        //            case FirstEnum.Rock:
        //                print("equality");
        //                break;
        //            case FirstEnum.Paper:
        //                print("first lose");
        //                break;
        //            case FirstEnum.Scissors:
        //                print("win lose");
        //                break;
        //        }
        //        break;
        //    case "paper":
        //        switch (secondCase)
        //        {
        //            case "rock":
        //                break;
        //            case "paper":
        //                print("first lose");
        //                break;
        //            case "scissors":
        //                break;
        //        }
        //        break;
        //    case "scissors":
        //        switch (secondCase)
        //        {
        //            case "rock":
        //                print("first lose");

        //                break;
        //            case "paper":
        //                print("first win");
        //                break;
        //            case "scissors":

        //                break;
        //        }
        //        break;
        //}

    }

    string RockPapaerScissors(Shape men, Shape dusmen) =>
    (men, dusmen) switch
    {
        (Shape.Rock, Shape.Paper) => "Men uduzdum",
        (Shape.Rock, Shape.Scissors) => "Men uddum",
        (Shape.Paper, Shape.Rock) => "men uddum",
        (Shape.Paper, Shape.Scissors) => "dusmen uddu",
        (Shape.Scissors, Shape.Rock) => "Men uduzdum",
        (Shape.Scissors, Shape.Scissors) => "beraber",
        (Shape.Rock, Shape.Rock) => "beraber",
        (Shape.Paper, Shape.Paper) => "beraber",
        (_, _) => "hecne vermemisen"
    };

// Update is called once per frame
void Update()
    {
        
    }

    //string CheckPaper(string str)
    //{
    //    switch (str)
    //    {
    //        case "rock":
    //            return "";
    //            print("equality");
    //            break;
    //        case "paper":
    //            print("first lose");
    //            break;
    //        case "scissors":
    //            print("win lose");
    //            break;
    //    }
    //}

    public void CallMe(int damage)
    {
        print(100 - damage);
    }
}

public enum Shape
{
    Rock,
    Paper,
    Scissors
}