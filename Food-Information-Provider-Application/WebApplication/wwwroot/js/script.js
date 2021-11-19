var buttonUrl = document.getElementById("button_url");
var buttonFile = document.getElementById("button_file");
var formUrl = document.getElementById("form_url");
var formFile = document.getElementById("form_file");

buttonUrl.addEventListener("click", () => {
    formUrl.classList.remove("hide");
    formFile.classList.add("hide");
});

buttonFile.addEventListener("click", () => {
    formFile.classList.remove("hide");
    formUrl.classList.add("hide");
});