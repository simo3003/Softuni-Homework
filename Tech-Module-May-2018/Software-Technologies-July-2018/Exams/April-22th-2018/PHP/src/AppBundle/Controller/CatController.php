<?php

namespace AppBundle\Controller;

use AppBundle\Entity\Cat;
use AppBundle\Form\CatType;
use AppBundle\Repository\CatRepository;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class CatController extends Controller
{
    /**
     * @Route("/", name="homepage")
     */
    public function index(Request $request)
    {
        $cats = $this
        ->getDoctrine()
        ->getRepository(Cat::class)
        ->findAll();
        
        return $this->render('cat/index.html.twig', ['cats'=>$cats]);
    }

    /**
     * @Route("/create", name="create")
     */
    public function create(Request $request)
    {
        $cat = new Cat();
        $form = $this->createForm(CatType::class, $cat);
        $form->handleRequest($request);
        if ($form->isSubmitted()) {
            $em = $this->getDoctrine()->getManager();
            $em->persist($cat);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render("cat/create.html.twig", ["form" => $form->createView()]);
    }

    /**
     * @Route("/edit/{id}", name="edit")
     */
    public function edit($id, Request $request)
    {
        $cat = $this->getDoctrine()->getRepository(Cat::class)->find($id);
        $form = $this->createForm(CatType::class,$cat);
        $form->handleRequest($request);
        if ($form->isSubmitted()){
            $em = $this->getDoctrine()->getManager();
            $em->persist($cat);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render('cat/edit.html.twig', ['form'=>$form->createView(), 'cat'=>$cat]);
    }

    /**
     * @Route("/delete/{id}", name="delete")
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\RedirectResponse|\Symfony\Component\HttpFoundation\Response
     */
    public function delete($id, Request $request)
    {
        $cat = $this->getDoctrine()->getRepository(Cat::class)->find($id);
        $form = $this->createForm(CatType::class,$cat);
        $form->handleRequest($request);
        if ($form->isSubmitted()){
            $em = $this->getDoctrine()->getManager();
            $em->remove($cat);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render('cat/delete.html.twig', ['form'=>$form->createView(), 'cat'=>$cat]);
    }
}
