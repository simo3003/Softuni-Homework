const Cat = require('../models').Cat;

module.exports = {
    index: (req, res) => {
        Cat.findAll().then(cats => {
            res.render('cat/index', { cats: cats });
        });
    },

    createGet: (req, res) => {
        res.render('cat/create')
    },

    createPost: (req, res) => {
        let args = req.body.cat;

        Cat.create(args)
            .then((cat) => {
                res.redirect('/')
            })
    },

    editGet: (req, res) => {
        let id = req.params.id;
        Cat.findById(id)
            .then(cat => {
                res.render('cat/edit', { cat: cat.dataValues })
            });
    },

    editPost: (req, res) => {
        let args = req.body.cat;
        let id = req.params.id;
        Cat.findById(id)
            .then(cat => {
                cat.updateAttributes(args).then(() => res.redirect('/'));
            });
    },

    deleteGet: (req, res) => {
        let id = req.params.id;
        Cat.findById(id)
            .then(cat => {
                res.render('cat/delete', { cat: cat.dataValues })
            });
    },

    deletePost: (req, res) => {
        let id = req.params.id;
        Cat.findById(id)
            .then(cat => {
                cat.destroy().then(() => res.redirect('/'));
            });
    }
};
