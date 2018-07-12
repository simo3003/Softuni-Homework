const Post = require('./../models/index').Post;
const User = require('./../models/index').User;
const sequzlize = require('sequelize');
module.exports = {
    index: (req, res) => {
        Post.findAll({
            limit: 6,
            include: [{
                model: User
            }]
        })
            .then(posts => {
                res.render('home/index', { posts: posts });
            });
    },
};


