const catController = require('../controllers/cat');

module.exports = (app) => {
    app.get('/', catController.index);

    app.get('/create/', catController.createGet);
    app.post('/create/', catController.createPost);

    app.get('/edit/:id', catController.editGet);
    app.post('/edit/:id', catController.editPost);

    app.get('/delete/:id', catController.deleteGet);
    app.post('/delete/:id', catController.deletePost);
};