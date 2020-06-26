package com.swing.hito4.repository;

import com.swing.hito4.model.Datamodel;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.List;
@Repository
public interface Datarepository extends JpaRepository<Datamodel, Integer> {
    @Query(value = "SELECT* FROM Alphabet WHERE types ='first';", nativeQuery = true)
    public List<Datamodel> getFirstRow();
    @Query(value="SELECT * FROM Alphabet WHERE types='second';", nativeQuery=true)
    public List<Datamodel> getSecondRow();

    @Query(value="SELECT * FROM Alphabet WHERE types='three';", nativeQuery=true)
    public List<Datamodel> getThreeRow();
}
