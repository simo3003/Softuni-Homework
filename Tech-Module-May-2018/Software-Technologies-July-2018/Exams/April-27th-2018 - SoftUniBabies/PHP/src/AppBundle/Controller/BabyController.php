<?php

namespace AppBundle\Controller;

use AppBundle\Entity\Baby;
use AppBundle\Form\BabyType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class BabyController extends Controller
{
   /**
    * @Route("/", name="homepage")
    */
    public function index(Request $request) {
    $babies = $this
        ->getDoctrine()
        ->getRepository(Baby::class)
        ->findAll();
    return $this->render("baby/index.html.twig", ['babies'=>$babies]);
    }

    /**
     * @param Request $request
     * @Route("/create", name="create")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function create(Request $request) {
        $baby = new Baby();
        $form = $this->createForm(BabyType::class,$baby);
        $form->handleRequest($request);
        if ($form->isSubmitted()) {
            $em = $this->getDoctrine()->getManager();
            $em->persist($baby);
            $em->flush();
            return $this->redirect('/');
        }
        return $this->render("baby/create.html.twig", array('form'=>$form->createView()));
    }

    /**
     * @Route("/edit/{id}", name="edit")
     *
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function edit($id, Request $request) {
    $baby = $this->getDoctrine()->getRepository(Baby::class)->find($id);
    $form = $this->createForm(BabyType::class,$baby);
    $form->handleRequest($request);
    if ($form->isSubmitted()) {
        $em = $this->getDoctrine()->getManager();
        $em->persist($baby);
        $em->flush();
        return $this->redirect('/');
    }
    return $this->render('baby/edit.html.twig', ['form'=>$form->createView(), 'baby'=>$baby]);
}

    /**
 * @Route("/delete/{id}", name="delete")
 * @param $id
 * @param Request $request
 * @return \Symfony\Component\HttpFoundation\RedirectResponse\Symfony\Component\HttpFoundation\Response
 */
public function delete($id, Request $request) {
    $baby = $this->getDoctrine()->getRepository(Baby::class)->find($id);
    $form = $this->createForm(BabyType::class,$baby);
    $form->handleRequest($request);
    if ($form->isSubmitted()) {
        $em = $this->getDoctrine()->getManager();
        $em->remove($baby);
        $em->flush();
        return $this->redirect('/');
    }
    return $this->render('baby/delete.html.twig', ['form'=>$form->createView(), 'baby'=>$baby]);
}
}
