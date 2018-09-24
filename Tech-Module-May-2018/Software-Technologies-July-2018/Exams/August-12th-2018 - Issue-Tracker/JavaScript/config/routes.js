const issueController = require('../controllers/issue');

module.exports = (app) => {
    app.get('/', issueController.index);

    app.get('/create/', issueController.createGet);
    app.post('/create/', issueController.createPost);

    app.get('/edit/:id', issueController.editGet);
    app.post('/edit/:id', issueController.editPost);

    app.get('/delete/:id', issueController.deleteGet);
    app.post('/delete/:id', issueController.deletePost);
};