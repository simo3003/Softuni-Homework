package javaBlog.repository;


import org.springframework.data.jpa.repository.JpaRepository;
import javaBlog.entity.User;

public interface UserRepository extends JpaRepository<User, Integer> {
    User findByEmail(String email);
}