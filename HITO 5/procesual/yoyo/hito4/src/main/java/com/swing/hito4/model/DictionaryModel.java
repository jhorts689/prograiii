package com.swing.hito4.model;

import javax.persistence.*;

@Entity
@Table(name = "Dictionary")
public class DictionaryModel {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer Id;

    @Column(name = "english", length = 200, nullable = false)
    private String ENGLISH;

    @Column(name = "portugues", length = 200, nullable = false)
    private String PORTUGUES;
    @Column(name = "word", length = 200, nullable = false)
    private String WORD;
    public DictionaryModel(){
    }
    public DictionaryModel(String ENGLISH, String PORTUGUES, String WORD){
        this.ENGLISH = ENGLISH;
        this.PORTUGUES = PORTUGUES;
        this.WORD =WORD;
    }

    public Integer getId() {
        return Id;
    }

    public void setId(Integer id) {
        Id = id;
    }

    public String getENGLISH() {
        return ENGLISH;
    }

    public void setENGLISH(String ENGLISH) {
        this.ENGLISH = ENGLISH;
    }

    public String getPORTUGUES() {
        return PORTUGUES;
    }

    public void setPORTUGUES(String PORTUGUES) {
        this.PORTUGUES = PORTUGUES;
    }

    public String getWORD() {
        return WORD;
    }

    public void setWORD(String WORD) {
        this.WORD = WORD;
    }
}
