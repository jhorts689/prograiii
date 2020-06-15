package com.goowia.swing.gui.util;

import org.springframework.stereotype.Component;

import javax.swing.*;
import java.awt.*;
import java.net.URL;

@Component
public class Util {
    public static final ImageIcon SUCCESS_IMAGE = new ImageIcon(Util.class.getClassLoader().getResource("images/success.jpg"));
    public static final ImageIcon FAILED_IMAGE = new ImageIcon(Util.class.getClassLoader().getResource("images/failed.jpg"));
    public static final Font FONT_TEXT = new Font("Arial", Font.BOLD, 28);

//    private static URL getResourcePath(String nameImg) {
//        return Util.class.getClassLoader().getResource(nameImg);
//    }

    public Util() {}
}
