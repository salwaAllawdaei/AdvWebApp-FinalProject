//console.log("dfdsfsd");
let todoAppointmentUrl = "https://localhost:7205/api/todo";

let todoEl = document.getElementById("appointments");
document.getElementById("appointment-submit").addEventListener("click", async () => {
    let customerNameEl = document.getElementById("customer-name");
    let customerContEl = document.getElementById("customer-cont");
    let appointmentDetailsEl = document.getElementById("appointment-details");
    let appointmentDateEl = document.getElementById("appointment-date");
    let appointmentConfirmedEl = document.getElementById("appointment-confirmed");
    let appointmentCommentsEl = document.getElementById("appointment-comments");
    let customerName = customerNameEl.value;
    let customerCont = customerContEl.value;
    let appointmentDetails = appointmentDetailsEl.value;
    let appointmentDate = appointmentDateEl.value;
    let appointmentConfirmed = appointmentConfirmedEl.checked;
    let appointmentComments = appointmentCommentsEl.value;
    if (customerName.trim() != '') {
        let newAppointment = { CustomerNm: customerName, Contact: customerCont, Details: appointmentDetails, AppointmentDateTime: appointmentDate, IsConfirmed: appointmentConfirmed, Comments: appointmentComments };

        let newTodoAppointment = await fetch(todoAppointmentUrl,
            {
                cache: 'no-cache',
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    Accept: 'application/json'
                },
                body: JSON.stringify(newAppointment)
            });
        getAppointments();
        customerNameEl.value = "";
    }
});

document.getElementById("btnupdate").addEventListener("click", async () => {
    let editAppointmentIdEl = document.getElementById("appointment-update");
    let editAppointmentId = editAppointmentIdEl.value;
    if (editAppointmentId.trim() != '') {
        let editAppointment = { toDoAppointmentId: editAppointmentId };
        let editTodoAppointment = await fetch((todoAppointmentUrl + "/" + editAppointmentId),
            {
                cache: 'no-cache',
                method: 'PATCH',
                headers: {
                    'Content-Type': 'application/json',
                    Accept: 'application/json'
                },
                body: JSON.stringify(editAppointment)
            });
        getAppointments();
        editAppointmentIdEl.value = "";
    }
});

document.getElementById("btndelete").addEventListener("click", async () => {
    let delAppointmentIdEl = document.getElementById("appointment-delete");
    let delAppointmentId = delAppointmentIdEl.value;
    if (delAppointmentId.trim() != '') {
        let delAppointment = { toDoAppointmentId: delAppointmentId };
        let delTodoAppointment = await fetch((todoAppointmentUrl + "/" + delAppointmentId),
            {
                cache: 'no-cache',
                method: 'DELETE',
                headers: {
                    'Content-Type': 'application/json',
                    Accept: 'application/json'
                },
                body: JSON.stringify(delAppointment)
            });
        getAppointments();
        delAppointmentIdEl.value = "";
    }
});

let getAppointments = async function () {
    let doAppointments = await (await fetch(todoAppointmentUrl,
        {
            cache: 'no-cache',
            method: 'GET'
        })).json();
    let html = "";
    html += "<ol>";
    html += "<div> Customer Number</div>";
    for (let i = 0; i < doAppointments.length; i++) {
        html += `<li class="complete${doAppointments[i].isConfirmed}">${doAppointments[i].toDoAppointmentId}  ${doAppointments[i].customerNm}</li>`;
    }
    html += "</ol>";
    todoEl.innerHTML = html;
}

getAppointments();
//////////////
let showMiniGallery = false;
let miniGallery = document.getElementById("minigallery");

let showHide = function () {
    if (showMiniGallery) {
        miniGallery.style.display = "block";
    } else {
        miniGallery.style.display = "none";
    }
}

showHide();
document.getElementById("show-mini").addEventListener("click", function () {
    showMiniGallery = !showMiniGallery;
    showHide();
});


let showMiniGallery1 = false;
let miniGallery1 = document.getElementById("minigallery1");

let showHide1 = function () {
    if (showMiniGallery1) {
        miniGallery1.style.display = "block";
    } else {
        miniGallery1.style.display = "none";
    }
}

showHide1();
document.getElementById("show-mini1").addEventListener("click", function () {
    showMiniGallery1 = !showMiniGallery1;
    showHide1();
});
let showMiniGallery2 = false;
let miniGallery2 = document.getElementById("minigallery2");

let showHide2 = function () {
    if (showMiniGallery2) {
        miniGallery2.style.display = "block";
    } else {
        miniGallery2.style.display = "none";
    }
}

showHide2();
document.getElementById("show-mini2").addEventListener("click", function () {
    showMiniGallery2 = !showMiniGallery2;
    showHide2();
});