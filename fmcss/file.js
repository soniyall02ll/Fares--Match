//mobile hamburger
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

setInterval(mufun1, 1000);
function mufun1() {
    let b11 = document.getElementById("moretravelON");
    let b21 = document.getElementById("moretravelOFF");
    let view1 = document.getElementById("view");
    let arrow1 = document.getElementById("arrowicon");

    b11.addEventListener("click", function () {
        if ((view1.style.display = "none")) {
            view1.style.display = "block";
            arrow1.style.display = "none";
        }
    })

    b21.addEventListener("click", function () {
        if ((view1.style.display = "block")) {
            view1.style.display = "none";
            arrow1.style.display = "block";
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

document.addEventListener("DOMContentLoaded", () => {

    const openDropdown = d => {
        if (!d) return;
        d.style.display = "block";
        requestAnimationFrame(() => {
            Object.assign(d.style, {
                transform: "translateY(0)",
                opacity: "1",
                pointerEvents: "auto"
            });
            d.dataset.open = "true";
        });
    };

    const closeDropdown = d => {
        if (!d) return;
        Object.assign(d.style, {
            transform: "translateY(100%)",
            opacity: "0",
            pointerEvents: "none"
        });
        d.dataset.open = "false";
        setTimeout(() => d.style.display = "none", 200);
    };

    const toggleDropdown = d => {
        if (!d) return;
        const open = d.dataset.open === "true";
        open ? closeDropdown(d) : openDropdown(d);
    };

    document.querySelectorAll(".fa-xmark").forEach(i =>
        i.addEventListener("click", e => closeDropdown(e.target.closest(".tripdrop, .Classdrop")))
    );

    document.querySelectorAll("#mySelect label, #mySelect1 label").forEach(l =>
        l.addEventListener("click", e => {
            const d = e.target.closest("#mySelect")?.querySelector(".tripdrop") ||
                e.target.closest("#mySelect1")?.querySelector(".Classdrop");
            toggleDropdown(d);
        })
    );

    document.querySelectorAll(".tripdrop input[type=radio], .Classdrop input[type=radio]").forEach(r =>
        r.addEventListener("change", e => {
            const dropdown = e.target.closest(".tripdrop, .Classdrop");
            const wrapper = dropdown.closest("#mySelect") || dropdown.closest("#mySelect1");
            const span = wrapper?.querySelector("label span");
            const text = dropdown.querySelector(`label[for="${e.target.id}"]`)?.textContent?.trim();
            if (span && text) span.textContent = text;
            closeDropdown(dropdown);
        })
    );

    document.addEventListener("click", e => {
        document.querySelectorAll(".tripdrop[data-open='true'], .Classdrop[data-open='true']").forEach(d => {
            if (!d.contains(e.target) && !e.target.closest("#mySelect, #mySelect1")) {
                closeDropdown(d);
            }
        });
    });
});


document.querySelectorAll('.newfaqhead').forEach(head => {
    head.addEventListener('click', () => {
        const detail = head.nextElementSibling; // Get the next sibling (headdetail)
        const plusIcon = head.querySelector('.fa-caret-down');
        const minusIcon = head.querySelector('.fa-caret-up');

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

//tabs
function TabFun() {
    // Get all tab sections
    const tabSections = document.querySelectorAll(".tabs");

    // Loop through each tab section
    tabSections.forEach((section) => {
        const tabs = section.querySelectorAll("[id^='tab']");
        const tabDetails = section.querySelectorAll("[id^='tabdetail']");

        // Initial setup: underline the first tab in each section
        tabs[0].style.borderBottom = "2px solid var(--primary-color)";
        tabs[0].style.color = "var(--primary-color)";
        tabDetails[0].style.display = "block"; // Show the first tab detail

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
}
document.addEventListener("DOMContentLoaded", () => {
    TabFun();
});


// form placeholder
const fields = document.querySelectorAll('.calendar, .calendar1, .user, .location, .location1');

fields.forEach(field => {
    field.addEventListener('input', function () {
        if (this.value) {
            this.classList.add('typing');
        } else {
            this.classList.remove('typing');
        }
    });
});

function hideAllDetails() {
    const allDetails = document.querySelectorAll('.linkdetails');
    allDetails.forEach(detail => detail.style.display = 'none');
    const allPlusIcons = document.querySelectorAll('.fa-plus');
    const allMinusIcons = document.querySelectorAll('.fa-minus');
    const allLinkHeads = document.querySelectorAll('.linkhead');
    allPlusIcons.forEach(plus => plus.style.display = 'inline');
    allMinusIcons.forEach(minus => minus.style.display = 'none');
    allLinkHeads.forEach(linkhead => linkhead.classList.remove('active-linkhead'));
}

// Add click event listener to all linkheads
const linkHeads = document.querySelectorAll('.linkhead');
linkHeads.forEach(link => {
    link.addEventListener('click', function () {
        const tabNumber = this.getAttribute('data-tab');
        const tabContent = document.getElementById('linktab' + tabNumber);
        if (tabContent.style.display === 'none' || !tabContent.style.display) {
            hideAllDetails();  // First hide all others
            tabContent.style.display = 'block';  // Show the selected tab
            this.querySelector('.fa-plus').style.display = 'none';
            this.querySelector('.fa-minus').style.display = 'inline';
            this.classList.add('active-linkhead');
        } else {
            tabContent.style.display = 'none';
            this.querySelector('.fa-plus').style.display = 'inline';
            this.querySelector('.fa-minus').style.display = 'none';
            this.classList.remove('active-linkhead');
        }
    });
});

// Initialize by hiding all details
hideAllDetails();

const para = document.getElementById("changeflights");
const column = document.getElementById("changeflight1");

para.addEventListener("click", function () {
    if (column.style.display === "none" || column.style.display === "") {
        column.style.display = "block";  // Show
    } else {
        column.style.display = "none";   // Hide
    }
});

document.addEventListener("DOMContentLoaded", function () {
    const tripRadios = document.querySelectorAll("#mySelect input[name='flight_way']");
    const tripSpan = document.querySelector("#mySelect label span");
    const classRadios = document.querySelectorAll("#mySelect1 input[name='flight_class']");
    const classSpan = document.querySelector("#mySelect1 label span");

    tripRadios.forEach(radio => {
        radio.addEventListener("change", function () {
            if (this.checked) {
                tripSpan.textContent = this.nextElementSibling.textContent;
            }
        });
    });
    classRadios.forEach(radio => {
        radio.addEventListener("change", function () {
            if (this.checked) {
                classSpan.textContent = this.nextElementSibling.textContent;
            }
        });
    });
});



$(document).ready(function () {
    var selectFrom = false;
    var selectTo = false;

    $('#flight_from').autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/api/getairport",
                dataType: "json",
                data: {
                    pickUpLocation: request.term
                },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            value: item.Code,
                            label: (item.Code + "-" + item.Name + ", " + item.CityName)
                        }
                    }));
                }
            })
        },
        open: function (event, ui) { selectFrom = true; },
        select: function (event, ui) {
            $(this).val(ui.item.label);
            selectFrom = false;
            return false;
        },
        close: function (event, ui) {
            selectFrom = false;
        },
        minLength: 3,
        autoFocus: true
    }).blur(function () {
        if (selectFrom) {
            $("#flight_from").val($('ul.ui-autocomplete li:first a').text());
        }
    }).focus(function () {
        $(this).autocomplete("search");
    });

    $("#flight_to").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/api/getairport",
                dataType: "json",
                data: {
                    pickUpLocation: request.term
                },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            value: item.Code,
                            label: (item.Code + "-" + item.Name + ", " + item.CityName)
                        }
                    }));
                }
            })
        },
        open: function (event, ui) {
            selectTo = true;
        },
        select: function (event, ui) {
            $(this).val(ui.item.label);
            selectTo = false;
            return false;
        },
        close: function (event, ui) {
            selectTo = false;
        },
        minLength: 3,
        autoFocus: true
    }).blur(function () {
        if (selectTo) {
            $("#flight_to").val($('ul.ui-autocomplete li:first a').text());
        }
    }).focus(function () {
        $(this).autocomplete("search");
    });
});

function initializeSlider(sliderSelector, slideSelector, dotSelector, nextBtnSelector, prevBtnSelector, defaultSlidesToShow = 1, gap = 0) {
    const slider = document.querySelector(sliderSelector);
    const slides = document.querySelectorAll(slideSelector);
    const dots = document.querySelectorAll(dotSelector);
    const nextBtn = document.querySelector(nextBtnSelector);
    const prevBtn = document.querySelector(prevBtnSelector);
    let currentIndex = 0;
    const totalSlides = slides.length;
    const getSlidesToShow = () => window.innerWidth <= 768 ? 1 : defaultSlidesToShow;
    const getSlideWidth = () => slides[0].clientWidth;
    let slidesToShow = getSlidesToShow();
    const updateSliderPosition = () => {
        slidesToShow = getSlidesToShow();
        const offset = -(getSlideWidth() + gap) * currentIndex;
        slider.style.transform = `translateX(${offset}px)`;
        updateDots();
        updateButtons();
    };

    const updateDots = () => {
        dots.forEach(dot => dot.classList.remove('active'));
        if (dots[currentIndex]) dots[currentIndex].classList.add('active');
    };

    const updateButtons = () => {
        prevBtn.classList.toggle('disabled', currentIndex === 0);
        nextBtn.classList.toggle('disabled', currentIndex >= totalSlides - slidesToShow);
    };

    const goToSlide = (index) => {
        currentIndex = index;
        updateSliderPosition();
    };

    const moveNext = () => {
        if (currentIndex < totalSlides - slidesToShow) {
            goToSlide(currentIndex + 1);
        }
    };

    const movePrev = () => {
        if (currentIndex > 0) {
            goToSlide(currentIndex - 1);
        }
    };

    let autoSlideInterval = setInterval(() => {
        currentIndex = (currentIndex < totalSlides - slidesToShow) ? currentIndex + 1 : 0;
        updateSliderPosition();
    }, 5000);

    const restartAutoSlide = () => {
        clearInterval(autoSlideInterval);
        autoSlideInterval = setInterval(() => {
            currentIndex = (currentIndex < totalSlides - slidesToShow) ? currentIndex + 1 : 0;
            updateSliderPosition();
        }, 5000);
    };

    nextBtn.addEventListener('click', () => { moveNext(); restartAutoSlide(); });
    prevBtn.addEventListener('click', () => { movePrev(); restartAutoSlide(); });

    dots.forEach(dot => {
        dot.addEventListener('click', (e) => {
            goToSlide(parseInt(e.target.getAttribute('data-slide')));
            restartAutoSlide();
        });
    });
    let startX = 0;
    let startTime = 0;

    slider.addEventListener('touchstart', function (e) {
        startX = e.changedTouches[0].screenX;
        startTime = new Date().getTime();
        restartAutoSlide();
    });

    slider.addEventListener('touchend', function (e) {
        const endX = e.changedTouches[0].screenX;
        const diff = endX - startX;
        const duration = new Date().getTime() - startTime;
        const slideWidth = getSlideWidth() + gap;
        let slidesToMove;
        slidesToMove = Math.floor(Math.abs(diff) / slideWidth);
        if (slidesToMove < 1) slidesToMove = 1;
        const swipeSpeed = Math.abs(diff) / duration;
        if (swipeSpeed > 0.5) {
            slidesToMove = diff < 0 ? totalSlides - slidesToShow - currentIndex : currentIndex;
        }
        if (diff < 0) {
            currentIndex = Math.min(currentIndex + slidesToMove, totalSlides - slidesToShow);
        } else {
            currentIndex = Math.max(currentIndex - slidesToMove, 0);
        }
        updateSliderPosition();
    });
}

initializeSlider('.slider4', '.slide4', '.dot4', '.next-btn4', '.prev-btn4', 4, 5);