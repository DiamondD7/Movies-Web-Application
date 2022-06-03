

const modal = document.querySelector('.genre-modal');
const overlay = document.querySelector('.overlay');
const genreList = document.querySelectorAll('.genre-list');

/*----------------------------Genre MODAL----------------------------------------*/
const closeModal = function () {
    modal.classList.add('hidden');
    overlay.classList.add('hidden');
    filterModal.classList.add('hidden');
}


document.querySelector('.genre').addEventListener('click', function () {

    modal.classList.remove('hidden');
    overlay.classList.remove('hidden');
})

document.addEventListener('keydown', function (e) {
    if (e.key === 'Escape') {
        closeModal()

    }
})


document.querySelector('.overlay').addEventListener('click', closeModal);

for (let i = 0; i < genreList.length; i++) {
    genreList[i].addEventListener('click', closeModal);
}



/*----------------------------FILTER MODAL----------------------------------------*/
const filterModal = document.querySelector('.filter-modal');

document.querySelector('.filter').addEventListener('click', function () {
    filterModal.classList.remove('hidden');
    overlay.classList.remove('hidden');
})



document.querySelector('.overlay').addEventListener('click', function () {
    filterModal.classList.add('hidden');
})