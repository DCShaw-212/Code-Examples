//Add get the btnSubmit by element id from the document and add the event listener
//click.  When click is triggered it should call storeDataAndValidateFor
document.getElementById("btnSubmit").addEventListener("click", storeDataAndValidateForm);

function storeDataAndValidateForm()
{

    /* Find out if the visa credit card was checked.  Set the local storage of
    credit type to visa.  I did this for you, since we didn't cover if statements
     */
    if(document.getElementById("creditCardVisa").checked) {
        localStorage.setItem("creditType", "Visa");
    }else if(document.getElementById("creditCardMasterCard").checked) {
        localStorage.setItem("creditType", "Master Card");
    }
    else{
        localStorage.setItem("creditType", "Discover");//Female radio button is checked

    }
    //Set the value of fname to a localStorage key called fname
    //JAS Need to get the element with the ide of fname, not fname and then get the value of
    //the element.  Change the remainder of them.
    localStorage.setItem("fname", document.getElementById("fname").value);
    //Set the value of lname to a localStorage key called lname
    localStorage.setItem("lname", document.getElementById("lname").value);
    //Set the value of amount to a localStorage key called amount
    localStorage.setItem("amount", document.getElementById("amount").value);
    //Set the value of credit to a localStorage key called creditCard
    localStorage.setItem("credit", document.getElementById("creditCard").value);


}
