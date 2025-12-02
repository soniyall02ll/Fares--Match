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


initializeSlider('.slider1', '.slide1', '.dot1', '.next-btn1', '.prev-btn1', 4, 15);
initializeSlider('.slider2', '.slide2', '.dot2', '.next-btn2', '.prev-btn2', 5, 15);
initializeSlider('.slider3', '.slide3', '.dot3', '.next-btn3', '.prev-btn3', 4, 15);