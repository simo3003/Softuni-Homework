const Baby = require('../models').Baby;

module.exports = {
    index: (req, res) => {
        Baby
            .findAll()
            .then(babies => {
                res.render('baby/index', { babies: babies })
            })
    },

    createGet: (req, res) => {
        res.render('baby/create');
    },

    createPost: (req, res) => {
        let args = req.body.baby;
        Baby.create(args)
            .then((baby) => {
                res.redirect('/');
            });
    },

    editGet: (req, res) => {
        let id = req.params.id;
        Baby.findById(id)
            .then(baby => {
                res.render('baby/edit', { baby: baby.dataValues })
            });
    },

    editPost: (req, res) => {
        let args = req.body.baby;
        let id = req.params.id;
        Baby.findById(id)
            .then(baby => {
                baby.updateAttributes(args)
                    .then(() => res.redirect('/'));
            });
    },

    deleteGet: (req, res) => {
        let id = req.params.id;
        Baby.findById(id)
            .then(baby => res.render('baby/delete', { baby: baby.dataValues }));
    },

    deletePost: (req, res) => {
        let id = req.params.id;
        Baby.findById(id)
            .then(baby => {
                baby.destroy()
                    .then(() => res.redirect('/'));
            });
    }
};