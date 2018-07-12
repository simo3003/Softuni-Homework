const userController = require('../controllers').user;
const homeController = require('../controllers').home;
const postController = require('../controllers').post;

module.exports = (app) =>{
    app.get('/',homeController.index);

    app.get('/user/register', userController.registerGet);
    app.post('/user/register', userController.registerPost);

    app.get('/user/login',userController.loginGet);
    app.post('/user/login',userController.loginPost);
    app.get('/user/logout',userController.logout);
    
    app.get('/post/create', postController.createGet);
    app.post('/post/create', postController.createPost);

    app.get('/post/details/:id', postController.details);

};
