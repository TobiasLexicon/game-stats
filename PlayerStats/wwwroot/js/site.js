

const getCityName = (url, teamName) => {
    //anropa
    $.get(`${url}?teamName=${teamName}`, function (response) {
        console.log(response);

        document.getElementById("Result").innerHTML = `${teamName} is from ${response}`;
    }
    )
    //hantera resultat
}