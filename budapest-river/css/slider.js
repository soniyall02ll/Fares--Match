function initializeSlider(sliderSelector, slideSelector, dotSelector, nextBtnSelector, prevBtnSelector) {
  const slider = document.querySelector(sliderSelector);
  const slides = document.querySelectorAll(slideSelector);
  const dots = document.querySelectorAll(dotSelector);
  let currentIndex = 0;
  const totalSlides = slides.length;
  const slideWidth = slides[0].clientWidth;

  document.querySelector(nextBtnSelector).addEventListener('click', () => {
      moveToNextSlide();
  });

  document.querySelector(prevBtnSelector).addEventListener('click', () => {
      moveToPrevSlide();
  });

  // Dot navigation
  dots.forEach(dot => {
      dot.addEventListener('click', (event) => {
          const slideIndex = event.target.getAttribute('data-slide');
          currentIndex = parseInt(slideIndex);
          updateSliderPosition();
          updateDots();
      });
  });

  function moveToNextSlide() {
      if (currentIndex < totalSlides - 1) {
          currentIndex++;
          updateSliderPosition();
      }
  }

  function moveToPrevSlide() {
      if (currentIndex > 0) {
          currentIndex--;
          updateSliderPosition();
      }
  }

  function updateSliderPosition() {
      const newPosition = -(slideWidth * currentIndex);
      slider.style.transform = `translateX(${newPosition}px)`;
      updateDots();
  }

  function updateDots() {
      dots.forEach(dot => dot.classList.remove('active'));
      dots[currentIndex].classList.add('active');
  }

  // Mouse wheel functionality
  slider.addEventListener('wheel', (event) => {
      if (event.deltaY > 0) {
          moveToNextSlide();
      } else {
          moveToPrevSlide();
      }
  });
}

// Initialize the first slider
initializeSlider('.slider', '.slide', '.dot', '.next-btn', '.prev-btn');
initializeSlider('.slider1', '.slide1', '.dot1', '.next-btn1', '.prev-btn1');
initializeSlider('.slider2', '.slide2', '.dot2', '.next-btn2', '.prev-btn2');
initializeSlider('.slider21', '.slide21', '.dot21', '.next-btn21', '.prev-btn21');
initializeSlider('.slider22', '.slide22', '.dot22', '.next-btn22', '.prev-btn22');