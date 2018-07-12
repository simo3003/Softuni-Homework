const Post = require('../models').Post;
const User = require('../models').User;
module.exports = {
    createGet: (req, res) => {
        res.render('post/create');
    },

    createPost: (req, res) => {
        let postArgs = req.body;

        let errorMsg = '';
        if (!req.isAuthenticated()) {
            errorMsg = 'Log in to make posts!';
        } else if (!postArgs.title) {
            errorMsg = 'Invalid or missing title!';
        } else if (!postArgs.title) {
            errorMsg = 'Invalid or missing content!';
        }

        if (errorMsg) {
            res.render('post/create', { error: errorMsg });
            return;
        }
        postArgs.authorId = req.user.id;

        Post.create(postArgs)
            .then((post) => {
                res.redirect('/');
            }).catch(err => {
                console.log(err.message);
                res.render('post/create', { error: err.message });
            });
    },

    details: (req, res) => {
        let id = req.params.id;
        Post.findById(id, {
            include: [
                {
                    model: User,
                }
            ]
        }).then(post => {
            res.render('post/details', post.dataValues);
        })
    }
};