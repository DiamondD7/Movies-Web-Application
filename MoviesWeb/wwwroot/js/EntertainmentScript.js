

const modal = document.querySelector('.genre-modal');
const overlay = document.querySelector('.overlay');

document.querySelector('.genre').addEventListener('click', function () {

    modal.classList.remove('hidden');
    overlay.classList.remove('hidden');
})


const closeModal = function () {
    modal.classList.add('hidden');
    overlay.classList.add('hidden');
}

document.querySelector('.overlay').addEventListener('click', closeModal);