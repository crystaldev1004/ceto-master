﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;

public class CheckAvailableFeatures : MonoBehaviour
{
    [SerializeField]
    Button m_SimpleAR;
    public Button simpleAR
    {
        get { return m_SimpleAR; }
        set { m_SimpleAR = value; }
    }

    [SerializeField]
    Button m_ImageTracking;
    public Button imageTracking
    {
        get { return m_ImageTracking; }
        set { m_ImageTracking = value; }
    }

    [SerializeField]
    Button m_Anchors;
    public Button anchors
    {
        get { return m_Anchors; }
        set { m_Anchors = value; }
    }

    [SerializeField]
    Button m_ARWorldMap;
    public Button ARWorldMap
    {
        get { return m_ARWorldMap; }
        set { m_ARWorldMap = value; }
    }
    

    [SerializeField]
    Button m_CameraImage;
    public Button cameraImage
    {
        get { return m_CameraImage; }
        set { m_CameraImage = value; }
    }

    [SerializeField]
    Button m_EnvironmentProbes;
    public Button environmentProbes
    {
        get { return m_EnvironmentProbes; }
        set { m_EnvironmentProbes = value; }
    }

    [SerializeField]
    Button m_ARCollaborationData;
    public Button ARCollaborationData
    {
        get { return m_ARCollaborationData; }
        set { m_ARCollaborationData = value; }
    }

    [SerializeField]
    Button m_ARKitCoachingOverlay;
    public Button ARKitCoachingOverlay
    {
        get { return m_ARKitCoachingOverlay; }
        set { m_ARKitCoachingOverlay = value; }
    }

    [SerializeField]
    Button m_Scale;
    public Button scale
    {
        get { return m_Scale; }
        set { m_Scale = value; }
    }

    [SerializeField]
    Button m_ObjectTracking;
    public Button objectTracking
    {
        get { return m_ObjectTracking; }
        set { m_ObjectTracking = value; }
    }

    [SerializeField]
    Button m_PlaneOcclusion;
    public Button planeOcclusion
    {
        get { return m_PlaneOcclusion; }
        set { m_PlaneOcclusion = value; }
    }

    [SerializeField]
    Button m_PointCloud;
    public Button pointCloud
    {
        get { return m_PointCloud; }
        set { m_PointCloud = value; }
    }

    [SerializeField]
    Button m_FaceTracking;
    public Button faceTracking
    {
        get { return m_FaceTracking; }
        set { m_FaceTracking = value; }
    }
    
    [SerializeField]
    Button m_FaceBlendShapes;
    public Button faceBlendShapes
    {
        get { return m_FaceBlendShapes; }
        set { m_FaceBlendShapes = value; }
    }

    [SerializeField]
    Button m_HumanSegmentation;
    public Button humanSegmentation
    {
        get { return m_HumanSegmentation; }
        set { m_HumanSegmentation = value; }
    }

    [SerializeField]
    Button m_LightEstimation;
    public Button lightEstimation
    {
        get { return m_LightEstimation; }
        set { m_LightEstimation = value; }
    }

    [SerializeField]
    Button m_PlaneDetection;
    public Button planeDetection
    {
        get { return m_PlaneDetection; }
        set { m_PlaneDetection = value; }
    }

    [SerializeField]
    Button m_PlaneClassification;
    public Button planeClassification
    {
        get { return m_PlaneClassification; }
        set { m_PlaneClassification = value; }
    }

#if UNITY_IOS
    OperatingSystem os = Environment.OSVersion;
#endif
    // Start is called before the first frame update
    void Start()
    {
        List<XRPlaneSubsystemDescriptor> planeDescriptors = new List<XRPlaneSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRPlaneSubsystemDescriptor>(planeDescriptors);

        List<XRRaycastSubsystemDescriptor> rayCastDescriptors = new List<XRRaycastSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRRaycastSubsystemDescriptor>(rayCastDescriptors);

        List<XRFaceSubsystemDescriptor> faceDescriptors = new List<XRFaceSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRFaceSubsystemDescriptor>(faceDescriptors);

        List<XRImageTrackingSubsystemDescriptor> imageDescriptors = new List<XRImageTrackingSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRImageTrackingSubsystemDescriptor>(imageDescriptors);

        List<XREnvironmentProbeSubsystemDescriptor> envDescriptors = new List<XREnvironmentProbeSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XREnvironmentProbeSubsystemDescriptor>(envDescriptors);

        List<XRAnchorSubsystemDescriptor> anchorDescriptors = new List<XRAnchorSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRAnchorSubsystemDescriptor>(anchorDescriptors);

        List<XRObjectTrackingSubsystemDescriptor> objectDescriptors = new List<XRObjectTrackingSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRObjectTrackingSubsystemDescriptor>(objectDescriptors);

        List<XRParticipantSubsystemDescriptor> participantDescriptors = new List<XRParticipantSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRParticipantSubsystemDescriptor>(participantDescriptors);

        List<XRDepthSubsystemDescriptor> depthDescriptors = new List<XRDepthSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRDepthSubsystemDescriptor>(depthDescriptors);

        List<XROcclusionSubsystemDescriptor> occlusionDescriptors = new List<XROcclusionSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XROcclusionSubsystemDescriptor>(occlusionDescriptors);

        List<XRCameraSubsystemDescriptor> cameraDescriptors = new List<XRCameraSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRCameraSubsystemDescriptor>(cameraDescriptors);

        List<XRSessionSubsystemDescriptor> sessionDescriptors = new List<XRSessionSubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors<XRSessionSubsystemDescriptor>(sessionDescriptors);

        if(planeDescriptors.Count > 0 && rayCastDescriptors.Count > 0)
        {
            m_SimpleAR.interactable = true;
            m_Scale.interactable = true;
        }  
        if(faceDescriptors.Count > 0)
        {
            m_FaceTracking.interactable = true;
#if UNITY_IOS
            m_FaceBlendShapes.interactable = true;
#endif

        }
        if(occlusionDescriptors.Count > 0)
        {
            foreach(XROcclusionSubsystemDescriptor occlusionDescriptor in occlusionDescriptors)
            {
                if(occlusionDescriptor.supportsHumanSegmentationDepthImage && occlusionDescriptor.supportsHumanSegmentationStencilImage)
                {
                    m_HumanSegmentation.interactable = true;
                    break;
                }
            }
        }
        if(cameraDescriptors.Count > 0)
        {
            foreach(var cameraDescriptor in cameraDescriptors)
            {
                if((cameraDescriptor.supportsAverageBrightness || cameraDescriptor.supportsAverageIntensityInLumens) && 
                    cameraDescriptor.supportsAverageColorTemperature && cameraDescriptor.supportsCameraConfigurations && 
                    cameraDescriptor.supportsCameraImage)
                {
                    m_LightEstimation.interactable = true;
                }
                  
            }
        }
        if(imageDescriptors.Count > 0)
        {
            m_ImageTracking.interactable = true;
        }
        if(envDescriptors.Count > 0)
        {
            m_EnvironmentProbes.interactable = true;
        }

        if(planeDescriptors.Count > 0)
        {
            m_PlaneDetection.interactable = true;
             foreach(var planeDescriptor in planeDescriptors)
            {
                if(planeDescriptor.supportsClassification)
                {
                    m_PlaneClassification.interactable = true;
                    break;
                }
            } 
        }
        if(anchorDescriptors.Count > 0)
        {
            m_Anchors.interactable = true;
        }
        if(objectDescriptors.Count > 0)
        {
            m_ObjectTracking.interactable = true;
        }
        if(cameraDescriptors.Count > 0)
        {
            foreach(var cameraDescriptor in cameraDescriptors)
            {
                if(cameraDescriptor.supportsCameraImage)
                {
                    m_CameraImage.interactable = true;
                    break;
                }
            }

        }
#if UNITY_IOS
        if(sessionDescriptors.Count > 0 /*&& ARKitSessionSubsystem.worldMapSupported*/)
        {
            m_ARWorldMap.interactable = true;
        }
#endif
        if(planeDescriptors.Count > 0 && rayCastDescriptors.Count > 0 && participantDescriptors.Count > 0)
        {
            m_ARCollaborationData.interactable = true;
        }

        if(depthDescriptors.Count > 0)
        {
            m_PointCloud.interactable = true;
        }

        if(planeDescriptors.Count > 0)
        {
            m_PlaneOcclusion.interactable  = true;
        }    
#if UNITY_IOS
        if(sessionDescriptors.Count > 0 /*&& ARKitSessionSubsystem.coachingOverlaySupported*/)
        {
            m_ARKitCoachingOverlay.interactable = true;
        }      
#endif
    }

}
