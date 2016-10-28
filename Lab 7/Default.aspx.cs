using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string userScore;
    Random random = new Random();
    static int random1, random2, random3, randomNumber, newScore = 0;
    static int dealerScore = 0;
    static int hit = 0;
    static int hit2 = 0;
    static int minimum17 = 0;




    protected void Page_Load(object sender, EventArgs e)
    {
        ButtonHit.Enabled = false;
        ButtonPass.Enabled = false;
        ButtonEnd.Enabled = false;

        LabelResult.ForeColor = System.Drawing.Color.White;

        LabelFinal.ForeColor = System.Drawing.Color.White;

        LabelScore.ForeColor = System.Drawing.Color.White;
    }

    protected void ButtonDeal_Click(object sender, EventArgs e)
    {
        ButtonHit.Enabled = true;
        ButtonDeal.Enabled = false;
        ButtonPass.Enabled = true;
        ButtonEnd.Enabled = true;
        minimum17 = 0;
        newScore = 0;
        hit = 0;
        hit2 = 0;

        random1 = random.Next(1, 11);
        setImageCardOne(random1);

        random2 = random.Next(1, 11);
        setImageCardTwo(random2);

        randomNumber = random1 + random2;

        LabelScore.Text = "Score = " + randomNumber;
    }

    protected void ButtonHit_Click(object sender, EventArgs e)
    {
        ButtonHit.Enabled = true;
        ButtonDeal.Enabled = false;
        ButtonPass.Enabled = true;
        ButtonEnd.Enabled = true;
        int random3 = random.Next(1, 11);

        hit++;


        if (hit == 1)
        {
            setImageCardThree(random3);
            newScore = randomNumber + random3;
        }
        else if (hit == 2)
        {
            setImageCardFour(random3);
            newScore = newScore + random3;
        }

        else if (hit == 3)
        {
            setImageCardFive(random3);

            newScore = newScore + random3;

        }
        else if (hit == 4)
        {
            setImageCardSix(random3);

            newScore = newScore + random3;

        }
        else if (hit == 5)
        {
            setImageCardSeven(random3);
            newScore = newScore + random3;

        }


        LabelScore.Text = "User Score = " + newScore;

        if (newScore > 21)
        {
            LabelResult.Text = "<h3 style='color:red'>You Lost</h3>";
            HyperLink.Visible = true;

        }
        else
        {

        }
    }

    protected void ButtonPass_Click(object sender, EventArgs e)
    {

        ButtonHit.Enabled = false;
        ButtonDeal.Enabled = false;
        ButtonPass.Enabled = false;
        ButtonEnd.Enabled = true;

        while (minimum17 < 17)
        {
            int randominside = random.Next(1, 11);

            minimum17 = minimum17 + randominside;

            hit2++;
            if (hit2 == 1)
            {
                setImageCardOneD(randominside);

            }
            else if (hit2 == 2)
            {
                setImageCardTwoD(randominside);

            }

            else if (hit2 == 3)
            {
                setImageCardThreeD(randominside);



            }
            else if (hit2 == 4)
            {
                setImageCardFourD(randominside);

            }
            else if (hit2 == 5)
            {
                setImageCardFiveD(randominside);


            }
            else if (hit2 == 6)
            {
                setImageCardSixD(randominside);


            }
            else if (hit2 == 7)
            {
                setImageCardSevenD(randominside);


            }

            LabelResult.Text = "<br>Dealer Score = " + minimum17 + "<h3 style='color:#FFD700'>You Win</h3>";
        }


        if (minimum17 > 21)
        {
            LabelResult.Text = "<br>Dealer Score = " + minimum17;
            LabelFinal.Text = "<h3 style='color:#FFD700'>You Win</h3>";
            HyperLink.Visible = true;
            dealerScore = 0;
        }
        else
        {
            LabelResult.Text = "<br>Dealer Score = " + minimum17;

            if (newScore > minimum17)
            {
                LabelFinal.Text = "<h3 style='color:#FFD700'>You Win</h3>";
                HyperLink.Visible = true;
                dealerScore = 0;
            }

            else if(newScore < minimum17)
            {
                LabelFinal.Text = "<br><h3 style='color:red'>You lost</h3>";
                HyperLink.Visible = true;
                dealerScore = 0;
            }
            else
            {
                LabelFinal.Text = "<br><h3 style='color:red'>Draw</h3>";
                HyperLink.Visible = true;
                dealerScore = 0;

            }

        }

    }


    public void setImageCardOne(int one)
    {
        if (one == 1)
        {
            ImageLeft.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageLeft.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageLeft.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageLeft.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageLeft.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageLeft.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageLeft.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageLeft.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageLeft.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageLeft.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardTwo(int one)
    {
        if (one == 1)
        {
            ImageRight.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageRight.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageRight.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageRight.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageRight.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageRight.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageRight.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageRight.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageRight.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageRight.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardThree(int one)
    {
        if (one == 1)
        {
            ImageThree.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageThree.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageThree.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageThree.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageThree.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageThree.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageThree.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageThree.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageThree.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageThree.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardFour(int one)
    {
        if (one == 1)
        {
            ImageFour.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageFour.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageFour.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageFour.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageFour.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageFour.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageFour.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageFour.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageFour.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageFour.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardFive(int one)
    {
        if (one == 1)
        {
            ImageFive.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageFive.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageFive.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageFive.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageFive.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageFive.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageFive.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageFive.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageFive.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageFive.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardSix(int one)
    {
        if (one == 1)
        {
            ImageSix.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageSix.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageSix.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageSix.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageSix.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageSix.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageSix.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageSix.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageSix.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageSix.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardSeven(int one)
    {
        if (one == 1)
        {
            ImageSeven.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            ImageSeven.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            ImageSeven.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            ImageSeven.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            ImageSeven.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            ImageSeven.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            ImageSeven.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            ImageSeven.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            ImageSeven.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            ImageSeven.ImageUrl = "images/ten.jpg";
        }


    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void setImageCardOneD(int one)
    {
        if (one == 1)
        {
            Image1.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image1.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image1.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image1.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image1.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image1.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image1.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image1.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image1.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image1.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardTwoD(int one)
    {
        if (one == 1)
        {
            Image2.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image2.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image2.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image2.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image2.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image2.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image2.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image2.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image2.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image2.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardThreeD(int one)
    {
        if (one == 1)
        {
            Image3.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image3.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image3.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image3.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image3.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image3.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image3.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image3.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image3.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image3.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardFourD(int one)
    {
        if (one == 1)
        {
            Image4.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image4.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image4.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image4.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image4.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image4.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image4.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image4.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image4.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image4.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardFiveD(int one)
    {
        if (one == 1)
        {
            Image5.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image5.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image5.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image5.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image5.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image5.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image5.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image5.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image5.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image5.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardSixD(int one)
    {
        if (one == 1)
        {
            Image6.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image6.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image6.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image6.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image6.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image6.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image6.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image6.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image6.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image6.ImageUrl = "images/ten.jpg";
        }


    }
    public void setImageCardSevenD(int one)
    {
        if (one == 1)
        {
            Image7.ImageUrl = "images/one.jpg";
        }
        else if (one == 2)
        {
            Image7.ImageUrl = "images/two.jpg";
        }
        else if (one == 3)
        {
            Image7.ImageUrl = "images/three.jpg";
        }
        else if (one == 4)
        {
            Image7.ImageUrl = "images/four.jpg";
        }
        else if (one == 5)
        {
            Image7.ImageUrl = "images/five.jpg";
        }
        else if (one == 6)
        {
            Image7.ImageUrl = "images/six.jpg";
        }
        else if (one == 7)
        {
            Image7.ImageUrl = "images/seven.jpg";
        }
        else if (one == 8)
        {
            Image7.ImageUrl = "images/eight.jpg";
        }
        else if (one == 9)
        {
            Image7.ImageUrl = "images/nine.jpg";
        }
        else if (one == 10)
        {
            Image7.ImageUrl = "images/ten.jpg";
        }


    }

    protected void ButtonEnd_Click(object sender, EventArgs e)
    {
        ButtonHit.Enabled = false;
        ButtonDeal.Enabled = false;
        ButtonPass.Enabled = false;
        ButtonEnd.Enabled = false;

        LabelFinal.Text = "Game Over!!<br><br>Refresh Page to play Again.";
        form1.Visible = false;
        LabelGAMEOVER.Text = "Game Over!!<br>Refresh page to Play Again.";
    }
}