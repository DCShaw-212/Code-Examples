//Add a window event listener of type load that calls displayData after the
//window loads
window.addEventListener("load", displayData);


function displayData(){
    //I did the first one for you.  Get the document element that has an id called first
    //and pyll the value that you set for the fname key in the processform.js file
    document.getElementById("first").innerHTML=localStorage.getItem("fname");
    //Get the last name from local storage
    document.getElementById("last").innerHTML=localStorage.getItem("lname");
    // Get the credit card number from local storage
    document.getElementById("creditCard").innerHTML=localStorage.getItem("creditCard");
    //get the credit card type from local storage
    document.getElementById("creditType").innerHTML=localStorage.getItem("creditType");
    //Get the amount from local storage
    document.getElementById("amount").innerHTML=localStorage.getItem("amount");
    //Get the amount from local storage and covert it to a float and store it in a variable
    //called amount
    var amount = parseFloat(localStorage.getItem("amount"));
    //Calculate the 15% processing fee
    var processingFee = .15 * amount;
    var pFee = processingFee.toString();

    //Display the processing fee in the processingFee field of the table
    localStorage.setItem("pFee", document.getElementById("processingFee").value);

    document.getElementById("processingFee").innerHTML=localStorage.getItem(pFee);

    //Add the processingFee to the amount and store it in a variable called total
     var total = processingFee + amount;
     var totalAmount = total.toString();
    //Display the total in the table field with id total
    localStorage.setItem("totalAmount", document.getElementById("total").value);

    document.getElementById("total").innerHTML=localStorage.getItem(totalAmount);

    console.log("Inside Display Data");
}