setInterval(mufun, 1000);
function mufun() {
    let b1 = document.getElementById("on");
    let b2 = document.getElementById("off");
    let view = document.getElementById("view");

    b1.addEventListener("click", function () {
        if ((view.style.display = "none")) {
            view.style.display = "block";

        }
    })

    b2.addEventListener("click", function () {
        if ((view.style.display = "block")) {
            view.style.display = "none";
        }
    })
}

const navLinks = document.querySelectorAll('nav ul a li');
const sections = document.querySelectorAll('section');

window.addEventListener('scroll', () => {
    sections.forEach((section) => {
        const sectionTop = section.offsetTop;
        const sectionHeight = section.clientHeight;

        if (window.scrollY >= sectionTop - sectionHeight / 3 && window.scrollY < sectionTop + sectionHeight) {
            navLinks.forEach((link) => {
                if (link.hash === section.id) {
                    link.classList.add('active');
                } else {
                    link.classList.remove('active');
                }
            });
        }
    });
});


document.querySelectorAll('.faqhead').forEach(head => {
    head.addEventListener('click', () => {
        const detail = head.nextElementSibling; // Get the next sibling (headdetail)
        const plusIcon = head.querySelector('.fa-chevron-down');
        const minusIcon = head.querySelector('.fa-chevron-up');

        detail.classList.toggle('show'); // Toggle visibility

        // Toggle icons
        if (detail.classList.contains('show')) {
            plusIcon.style.display = 'none'; // Hide plus
            minusIcon.style.display = 'inline'; // Show minus
        } else {
            plusIcon.style.display = 'inline'; // Show plus
            minusIcon.style.display = 'none'; // Hide minus
        }
    });
});