package com.swing.hito4.repository;

import com.swing.hito4.model.DictionaryModel;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface DictionaryRepository extends JpaRepository<DictionaryModel, Integer> {
    @Query(value = "SELECT* FROM Dictionary WHERE id = 1;", nativeQuery = true)
    public List <DictionaryModel> get1row();
    @Query(value = "SELECT* FROM Dictionary WHERE id = 2;", nativeQuery = true)
    public List <DictionaryModel> get2row();
    @Query(value = "SELECT* FROM Dictionary WHERE id = 3;", nativeQuery = true)
    public List <DictionaryModel> get3row();
    @Query(value = "SELECT* FROM Dictionary WHERE id = 4;", nativeQuery = true)
    public List <DictionaryModel> get4row();
    @Query(value = "SELECT* FROM Dictionary WHERE id = 5;", nativeQuery = true)
    public List <DictionaryModel> get5row();
    @Query(value = "SELECT* FROM Dictionary WHERE id = 6;", nativeQuery = true)
    public List <DictionaryModel> get6row();
    @Query(value = "SELECT* FROM Dictionary WHERE id = 7;", nativeQuery = true)
    public List <DictionaryModel> get7row();
}
