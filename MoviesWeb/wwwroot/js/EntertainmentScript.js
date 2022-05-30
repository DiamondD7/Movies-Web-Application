

const modal = document.querySelector('.genre-modal');
const overlay = document.querySelector('.overlay');

document.querySelector('.genre').addEventListener('click', function () {

    modal.classList.remove('hidden');
    overlay.classList.remove('hidden');
})