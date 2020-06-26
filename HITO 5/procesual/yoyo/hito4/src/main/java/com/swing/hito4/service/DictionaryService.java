package com.swing.hito4.service;

import com.swing.hito4.model.DictionaryModel;
import com.swing.hito4.repository.Datarepository;
import com.swing.hito4.repository.DictionaryRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.swing.hito4.service.*;

import java.util.ArrayList;
import java.util.List;

@Service
public class DictionaryService implements DictionaryServiceInterface {

    @Autowired
    private DictionaryRepository dictionaryRepository;

    @Override
    public void saveData() {
        if (dictionaryRepository.count() == 0) {
            dictionaryRepository.save(new DictionaryModel("Monday", "SEGNDA-FEIRA", "LUNES"));
            dictionaryRepository.save(new DictionaryModel("TUESDAY", "TERCA-FEIRA", "MARTES"));
            dictionaryRepository.save(new DictionaryModel("WEDNESDAY", "QUARTA-FEIRA", "MIERCOLES"));
            dictionaryRepository.save(new DictionaryModel("THURSDAY", "QUINTA-FEIRA", "JUEVES"));
            dictionaryRepository.save(new DictionaryModel("FRIDAY", "SEXTA-FEIRA", "VIERNES"));
            dictionaryRepository.save(new DictionaryModel("SATURDAY", "SABADO", "SABADO"));
            dictionaryRepository.save(new DictionaryModel("SUNDAY", "DOMINGO", "DOMINGO"));
        }
    }

    @Override
    public List<DictionaryModel> getAllLetters1() {
        return dictionaryRepository.get1row();
    }

    @Override
    public List<DictionaryModel> getAllLetters2() {
        return dictionaryRepository.get2row();
    }

    @Override
    public List<DictionaryModel> getAllLetters3() {
        return dictionaryRepository.get3row();
    }

    @Override
    public List<DictionaryModel> getAllLetters4() {
        return dictionaryRepository.get4row();
    }

    @Override
    public List<DictionaryModel> getAllLetters5() {
        return dictionaryRepository.get5row();
    }

    @Override
    public List<DictionaryModel> getAllLetters6() {
        return dictionaryRepository.get6row();
    }

    @Override
    public List<DictionaryModel> getAllLetters7() {
        return dictionaryRepository.get7row();
    }
}
