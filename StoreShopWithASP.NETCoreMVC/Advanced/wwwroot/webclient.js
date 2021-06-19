const username = "admin";
const password = "admins";
let token;

window.addEventListener("DOMContentLoaded", () => {
    const controlDiv = document.getElementById("controls");
    createButton(controlDiv, "Get Data", getData);
    createButton(controlDiv, "Log In", login);
    createButton(controlDiv, "Log Out", logout);
    
});

async function login() {
    let respone = await fetch("/api/account/token", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ username: username, password: password })
    });
    if (respone.ok) {
        token = (await respone.json()).token;
        displayData("Logged in",token);
    } else displayData(`Error: ${respone.status}: ${respone.statusText}`);
}
async function logout() {
    token = "";
    displayData("Logged out");
}

async function getData() {
    let res = await fetch("/api/people", {
        hearder: { "Authorization": `Bearer ${token}` }
        });
    if (res.ok) {
        let jsonData = await res.json();
        displayData(...jsonData.map(item => ` ${item.surname}, ${item.firstname}`));
    } else {
        displayData(`Error: ${res.status}: ${res.statusText}`);
    }
}

function displayData(...items) {
    const dataDiv = document.getElementById("data");
    dataDiv.innerHTML = "";
    items.forEach(item => {
        const itemDiv = document.createElement("div");
        itemDiv.innerText = item;
        itemDiv.style.wordWrap = "break-word";
        dataDiv.appendChild(itemDiv);
    })
}
function createButton(parent, label, handler) {
    const button = document.createElement("button");
    button.classList.add("btn", "btn-primary", "m-2");
    button.innerText = label;
    button.onclick = handler;
    parent.appendChild(button);
}
