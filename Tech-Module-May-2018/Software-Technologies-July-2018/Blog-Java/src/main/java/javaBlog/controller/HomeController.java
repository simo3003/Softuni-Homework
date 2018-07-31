package javaBlog.controller;

import javaBlog.entity.Post;
import javaBlog.repository.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import java.util.List;

@Controller
public class HomeController {
    @Autowired
    private PostRepository postRepository;

    @GetMapping("/")
    public String index(Model model) {
        List<Post> posts = this.postRepository.findAll();
        model.addAttribute("view", "home/index");
        model.addAttribute("posts", posts);
        return "base-layout";
    }
}
