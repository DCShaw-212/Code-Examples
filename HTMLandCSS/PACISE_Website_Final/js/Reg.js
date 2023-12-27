
// add an event listener to call saveDate when the submit button is clicked
document.getElementById("btnSubmit").addEventListener("click", saveData);

function saveData()
{
        /*Find out which status was selected*/

    //Was 2-Day Faculty/Professional selected id = "twoDayFP
    if(document.getElementById("twoDayFP").checked){
        localStorage.setItem("stat","2-Day Faculty/Professional");
    }
    //Was 1-Day Faculty/Profession selected id = "oneDayFP
    if(document.getElementById("oneDayFP").checked){
        localStorage.setItem("stat","1-Day Faculty/Professional");
    }
    //was Student selected id = student
    if(document.getElementById("student").checked){
        localStorage.setItem("stat","Student");
    }
    //was spouse/guest selected id = sp
    if (document.getElementById("student").checked)
    {
        localStorage.setItem("stat","Student");
    }


            /*Find out which participation was selected*/

    //Did they select the programming contest?
    if(document.getElementById("programmingContest").checked){
        localStorage.setItem("pt", "Programming Contest");
    }

    //Are they presenting a poster?
    if(document.getElementById("poster").checked){
        localStorage.setItem("pt", "Presenting a Poster");
    }

    //Are they there for the birds?
    if(document.getElementById("birds").checked){
        localStorage.setItem("pt","Birds of a feather");
    }

    //are they an attendee?
    if(document.getElementById("attendee").checked){
        localStorage.setItem("pt", "Attendee Only" );
    }

        /*The rest of the Data will be set here */

    //Set the value of fname to the local storage key called fname
    localStorage.setItem("fname", document.getElementById("fname").value);
    //Set the value of lname to a localStorage key called lname
    localStorage.setItem("lname", document.getElementById("lname").value);
    //Set the value of address1 to the local storage key called address1
    localStorage.setItem("address1", document.getElementById("address1").value);
    //Set the value of address2 to the local storage key called address2
    localStorage.setItem("address2", document.getElementById("address2").value);
    //Set the value of city to the local storage key called city
    localStorage.setItem("city", document.getElementById("city").value);
    //Set the value of state to the local storage key called state
    localStorage.setItem("state", document.getElementById("state").value);
    //Set the value of zipCode to the local storage key called zipCode
    localStorage.setItem("zipCode", document.getElementById("zipCode").value);
    //Set the value of email to the local storage key called email
    localStorage.setItem("email", document.getElementById("email").value);
    //Set the value of phone to the local storage key called phonw
    localStorage.setItem("phone", document.getElementById("phone").value);

    //Calculating the total due
    //parseInt(string) to get a numeric value from a string
    //initialize and find the base cost variable
    var bc = 0;

    //using conditional statements to determine which status was  selected
    if(document.getElementById("twoDayFP").checked){
        bc = 60;
    }
    else if (document.getElementById("oneDayFP").checked){
        bc = 30;
    }
    else
        bc = 20;
    }


    //determine and add 8% tax to the base cost

    let t = bc * .08;

    //add a $10 processing fee and tax to determine total cost due
    let td = bc + t + 10;

    //convert variables to a string-- might work for display issues
    bc.toString();
    t.toString();
    td.toString();

    //set the cost variables
    //base Cost set
    localStorage.setItem("bc"), document.getElementById("bc").value;

    //tax
    localStorage.setItem("t"), document.getElementById("t").value;
    //total
    localStorage.setItem("td"), document.getElementById("td").value;
}



