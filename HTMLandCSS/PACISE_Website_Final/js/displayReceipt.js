//Add a window event listener of type load that calls displayData after the
//window loads

window.addEventListener("load", displayData);


function displayData(){             //To                                           //from
    //get the first name
    document.getElementById("first").innerHTML=localStorage.getItem("fname");
    //get the last name
    document.getElementById("last").innerHTML=localStorage.getItem("lname");
    // Get the line one address
    document.getElementById("addressLine1").innerHTML=localStorage.getItem("address1");
    //get the line two address
    document.getElementById("addressLine2").innerHTML=localStorage.getItem("address2");
    //Get the city
    document.getElementById("c").innerHTML=localStorage.getItem("city");
    //Get the state
    document.getElementById("s").innerHTML=localStorage.getItem("state");
    //Get the zipCode
    document.getElementById("zc").innerHTML=localStorage.getItem("zipCode");
    //Get the email
    document.getElementById("email").innerHTML=localStorage.getItem("email");
    //Get the phone
    document.getElementById("phone").innerHTML=localStorage.getItem("phone")
    //Get the status
    document.getElementById("status").innerHTML=localStorage.getItem("stat");
    //Get the participation type
    document.getElementById("partType").innerHTML=localStorage.getItem("pt");
    //Get the base cost
    document.getElementById("baseCost").innerHTML=localStorage.getItem("bc");
    //Get the tax
    document.getElementById("tax").innerHTML=localStorage.getItem("t");
    //Get the total
    document.getElementById("totalDue").innerHTML=localStorage.getItem("td");


}