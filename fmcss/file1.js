function TabFun() {
    const tabSections = document.querySelectorAll(".tabs");
    tabSections.forEach((section) => {
        const tabs = section.querySelectorAll("[id^='tab']");
        const tabDetails = section.querySelectorAll("[id^='tabdetail']");
        tabs[0].style.borderBottom = "2px solid var(--primary-color)";
        tabs[0].style.color = "var(--primary-color)";
        tabDetails[0].style.display = "block";
        tabs.forEach((tab, index) => {
            tab.addEventListener("click", () => {
                tabDetails.forEach((detail, detailIndex) => {
                    if (detailIndex === index) {
                        detail.style.display = "block";
                        tabs[detailIndex].style.borderBottom = "2px solid var(--primary-color)";
                        tabs[detailIndex].style.color = "var(--primary-color)";
                    } else {
                        detail.style.display = "none";
                        tabs[detailIndex].style.border = "none";
                        tabs[detailIndex].style.color = "var(--fifth-color)";
                    }
                });
            });
        });
    });
}document.addEventListener("DOMContentLoaded", () => {
    TabFun();
});


setInterval(mufun, 1000);
function mufun() {
    let b1 = document.getElementById("on");
    let b2 = document.getElementById("off");
    let view = document.getElementById("view");
    let arrow = document.getElementById("arrowicon");

    b1.addEventListener("click", function () {
        if ((view.style.display = "none")) {
            view.style.display = "block";
            arrow.style.display = "none";
        }
    })

    b2.addEventListener("click", function () {
        if ((view.style.display = "block")) {
            view.style.display = "none";
            arrow.style.display = "block";
        }
    })
}

// navigation active on click
const currentPage = window.location.pathname.split("/").pop() || 'index.html';
const navLinks = document.querySelectorAll('ul li a');
navLinks.forEach(link => {
    if (link.getAttribute('href') === `./${currentPage}` || currentPage === '') {
        link.parentElement.classList.add('active');
    }
});